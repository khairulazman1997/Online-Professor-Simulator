using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PostLessonView : MonoBehaviour
{
    public void OnClickContinueButton()
    {
        OPSGameObject.Instance.StartNewLesson();
    }
}
