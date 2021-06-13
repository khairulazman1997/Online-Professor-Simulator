using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OPSGameObject : MonoBehaviour
{
    public static OPSGameObject Instance { get; private set; }

    /*** GAME STATE ***********************************************************/
    public Professor Professor;
    public List<Student> StudentList = new List<Student>();
    public int AverageAllegiance;
    public int Attentiveness;
    public List<Slide> SlideList;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        SlideList = UtilityTools.GenerateSlideListFromJSON();
        Professor = new Professor();
        GenerateStudents();
        Attentiveness = 0;
        UIController.Instance.UpdateView();
        UIController.Instance.StartSlidePicker();
    }

    void GenerateStudents()
    {
       int totalAllegiance = 0;
       while (StudentList.Count < 15)
        {
            Student student = new Student();
            StudentList.Add(student);
            totalAllegiance += student.Allegiance;
        }
       AverageAllegiance = totalAllegiance / 15;
    }

    public void RunSlide(Slide slide)
    {
        // Calculate new Suspicion Level
        Professor.SuspicionLevel = Mathf.Min(Professor.SuspicionLevel + slide.SuspicionModifier, 1000);
        Professor.SuspicionLevel = Mathf.Max(Professor.SuspicionLevel, 0);

        //Calculate Attention Level
        Attentiveness = Mathf.Min(Attentiveness + slide.AttentionModifier, 1000);
        Attentiveness = Mathf.Max(Attentiveness, 0);

        //Calculate Student Allegiance
        int totalAllegiance = 0;
        int noActiveStudents = 0;
        foreach (Student student in StudentList)
        {
            if (student.Status == Status.Active)
            {
                student.UpdateAllegiance(Attentiveness / 1000, slide.AllegianceModifier, slide.Topic);
                totalAllegiance += student.Allegiance;
                noActiveStudents++;
            }
        }
        Debug.Log("Total number of active students = " + noActiveStudents);
        AverageAllegiance = totalAllegiance / noActiveStudents;
        UIController.Instance.OpenCallView();
    }
    
}
