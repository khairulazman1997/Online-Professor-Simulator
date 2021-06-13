using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StudentShareView : MonoBehaviour
{
    public TMP_Text StudentName;
    public TMP_Text OpinionText;

    public Slide slide;
    public Student student;
    
    public void UpdateStudentShareView()
    {
        StudentName.text = student.Name;
        if (slide.Opinion == Opinion.Pro)
        {
            OpinionText.text = slide.ProOpinion;
        } else if (slide.Opinion == Opinion.Anti)
        {
            OpinionText.text = slide.AntiOpinion;
        } else
        {
            OpinionText.text = slide.NeutralOpinion;
        }
    }
}
