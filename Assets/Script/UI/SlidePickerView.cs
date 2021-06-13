using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlidePickerView : MonoBehaviour
{
    public List<SlideView> Slides;
    public Slide SelectedSlide;

    public Button ConfirmButton;

    public void ResetSelected()
    {
        ConfirmButton.interactable = false;
        foreach (SlideView slide in Slides)
        {
            slide.isSelected = false;
            slide.UpdateSlideView();
        }
    }

    public void OnClickConfirmButton()
    {
        OPSGameObject.Instance.RunSlide(SelectedSlide);
    }
}
