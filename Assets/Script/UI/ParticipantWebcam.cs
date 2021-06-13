using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ParticipantWebcam : MonoBehaviour
{
    public Image greenOutline;
    public Image reactionIcon;
    public Image participantWebcamVideo;
    public TMP_Text participantName;
    public TMP_Text allegiance;

    public IPerson participant;

    public void UpdateUIElements()
    {
        participantName.text = participant.Name;
        //TODO: Set the participant webcam video
        SetGreenOutline();
        SetReactionIcon();
        allegiance.text = "" + participant.Allegiance;
    }

    private void SetGreenOutline()
    {
        greenOutline.gameObject.SetActive(participant.isSpeaking);
    }

    private void SetReactionIcon()
    {
        bool isReacting = participant.Reaction > 0;
        if (isReacting)
        {
            //TODO: Set reaction icon
        }
        reactionIcon.gameObject.SetActive(isReacting);
    }
}
