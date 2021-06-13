using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StudentShareView : MonoBehaviour
{
    public TMP_Text StudentName;
    public TMP_Text Opinion;

    public Slide slide;
    public Student student;
    
    public void UpdateStudentShareView(string opinion)
    {
        StudentName.text = student.Name;
        Opinion.text = opinion;
    }
}
