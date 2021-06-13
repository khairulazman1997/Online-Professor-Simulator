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

    public void OnClickPraise()
    {
        if(slide.Opinion == Opinion.Pro)
        {
            OPSGameObject.Instance.ModifyStudentsAllegiance(50);
        } else if (slide.Opinion == Opinion.Anti)
        {
            OPSGameObject.Instance.ModifyStudentsAllegiance(-50);
        }
    }

    public void OnClickBerate()
    {
        if (slide.Opinion == Opinion.Pro)
        {
            OPSGameObject.Instance.ModifyStudentsAllegiance(-50);
        }
        else if (slide.Opinion == Opinion.Anti)
        {
            OPSGameObject.Instance.ModifyStudentsAllegiance(50);
        }
    }

    public void OnClickNod()
    {
        OPSGameObject.Instance.Attentiveness += 50;
    }

    public void OnClickKick()
    {
        student.Status = Status.Kicked;
        OPSGameObject.Instance.Attentiveness -=100;
    }

    public void OnClickReport()
    {
        student.Status = Status.Reported;
        OPSGameObject.Instance.Attentiveness -= 100;
    }
}
