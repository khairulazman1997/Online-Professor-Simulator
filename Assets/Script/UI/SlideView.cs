using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SlideView : MonoBehaviour
{
    public TMP_Text Topic;
    public TMP_Text AttentionEffect;
    public TMP_Text AllegianceEffect;
    public TMP_Text SuspicionEffect;
    public Image SlideImage;
    public Image SlideHiglight;

    public Slide Slide;

    public bool isSelected;

    public void UpdateSlideView()
    {
        Topic.text = "Topic: " + Slide.Topic.ToString();
        AttentionEffect.text = "Attention: " + SlideEffectToString(Slide.AttentionModifier);
        AllegianceEffect.text = "Allegiance: " + SlideEffectToString(Slide.AllegianceModifier);
        SuspicionEffect.text = "Suspicion: " + SlideEffectToString(Slide.SuspicionModifier);
        SlideHiglight.gameObject.SetActive(isSelected);
    }

    private string SlideEffectToString(int effect)
    {
        if (effect > 0)
        {
            return "+" + effect;
        } else
        {
            return "" + effect;
        }
        
    }

    public void OnClickSlideView()
    {
        UIController.Instance.SlidePickerView.SelectedSlide = this.Slide;
        UIController.Instance.SlidePickerView.ResetSelected();
        this.isSelected = true;
        UpdateSlideView();
    }
}
