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
        Professor = new Professor();
        GenerateStudents();
        UIController.Instance.PopulateWebcams();
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
    
}