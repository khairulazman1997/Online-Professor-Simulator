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
        PopulateWebcams();
        CallView.UpdateLevels();
    }

    public void PopulateWebcams()
    {
        Webcams[0].participant = OPSGameObject.Instance.Professor;
        for (int i = 1; i < Webcams.Count; i++)
        {
            Webcams[i].participant = OPSGameObject.Instance.StudentList[i - 1];
            Webcams[i].UpdateUIElements();
        }
    }

    public void OpenCallView()
    {
        UpdateCallView();
        CallView.gameObject.SetActive(true);
        SlidePickerView.gameObject.SetActive(false);
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

}
