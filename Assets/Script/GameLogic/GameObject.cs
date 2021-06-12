using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObject : MonoBehaviour
{
    public static GameObject Instance { get; private set; }

    /*** GAME STATE ***********************************************************/
    public Professor Professor = new Professor();
    public List<Student> StudentList = new List<Student>();
    public int AverageAllegiance;
    public int Attentiveness;

    // Start is called before the first frame update
    void Start()
    {
        GenerateStudents();
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
