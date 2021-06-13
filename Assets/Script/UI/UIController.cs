using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public static UIController Instance { get; private set; }

    //CallView elements
    public CallView CallView;
    public List<ParticipantWebcam> Webcams;

    //OpinionView Element
    public StudentShareView ShareView;

    //SlidePickerView elements
    public SlidePickerView SlidePickerView;

    public PostLessonView PostLessonView;

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

    public void UpdateCallView()
    {
        UpdateWebcams();
        CallView.UpdateLevels();
    }

    public void PopulateWebcams()
    {
        Webcams[0].participant = OPSGameObject.Instance.Professor;
        int index = 0;
        for (int i = 1; i < Webcams.Count; i++)
        {
            index = OPSGameObject.Instance.FindNextAvailableStudent(index);
            Webcams[i].participant = OPSGameObject.Instance.StudentList[index];
            Webcams[i].UpdateUIElements();
            index++;
        }
    }

    public void UpdateWebcams()
    {
        for (int i = 1; i < Webcams.Count; i++)
        {
            Webcams[i].UpdateUIElements();
        }
    }

    public void OpenCallView()
    {
        UpdateCallView();
        CallView.gameObject.SetActive(true);
        SlidePickerView.gameObject.SetActive(false);
        PostLessonView.gameObject.SetActive(false);
        ShareView.gameObject.SetActive(false);
        CallView.ShareScreenButton.interactable = true;
    }

    public void OpenStudentShareView(Slide slide, Student student)
    {
        CallView.ShareScreenButton.interactable = false;
        ShareView.student = student;
        ShareView.slide = slide;
        ShareView.UpdateStudentShareView();
    }

    public void StartSlidePicker()
    {
        CallView.gameObject.SetActive(false);
        SlidePickerView.gameObject.SetActive(true);
        SlidePickerView.ResetSelected();
        foreach (SlideView slideView in SlidePickerView.Slides)
        {
            int slideIndex = Mathf.FloorToInt(Random.value * OPSGameObject.Instance.SlideList.Count);
            Slide slide = OPSGameObject.Instance.SlideList[slideIndex];
            OPSGameObject.Instance.SlideList.RemoveAt(slideIndex);
            slideView.Slide = slide;
            slideView.UpdateSlideView();
        }
    }

    public void OpenReportView()
    {
        //Update Report View
        CallView.gameObject.SetActive(false);
        SlidePickerView.gameObject.SetActive(false);
        PostLessonView.gameObject.SetActive(true);
    }

}
