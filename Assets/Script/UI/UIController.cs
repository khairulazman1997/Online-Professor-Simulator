using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public static UIController Instance { get; private set; }
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

    // Start is called before the first frame update
    void Start()
    {

    }

    public void PopulateWebcams()
    {
        Webcams[0].participant = OPSGameObject.Instance.Professor;
        for (int i = 1; i < Webcams.Count; i++)
        {
            Debug.Log(i);
            Webcams[i].participant = OPSGameObject.Instance.StudentList[i - 1];
            Webcams[i].UpdateUIElements();
        }
    }

}
