using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public static UIController Instance { get; private set; }
    public CallView CallView;
    public List<ParticipantWebcam> Webcams;

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

    public void UpdateView()
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

}
