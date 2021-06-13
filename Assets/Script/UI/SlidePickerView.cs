using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlidePickerView : MonoBehaviour
{
    public List<SlideView> Slides;
    public Slide SelectedSlide;

    public void ResetSelected()
    {
        foreach (SlideView slide in Slides)
        {
            slide.isSelected = false;
            slide.UpdateSlideView();
        }
    }
}
