using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CallView : MonoBehaviour
{
    public TMP_Text AttentionLevel;
    public TMP_Text AllegianceLevel;
    public TMP_Text SuspicionLevel;

    public void UpdateLevels()
    {
        AttentionLevel.text = "Attentiveness: " + OPSGameObject.Instance.Attentiveness;
        AllegianceLevel.text = "Allegiance: " + OPSGameObject.Instance.AverageAllegiance;
        SuspicionLevel.text = "Suspicion: " + OPSGameObject.Instance.Professor.SuspicionLevel;
    }

    public void OnClickShareScreen()
    {
        UIController.Instance.StartSlidePicker();
    }
}
