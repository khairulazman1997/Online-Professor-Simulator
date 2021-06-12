using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Professor : MonoBehaviour, IPerson
{
    int IPerson.ID { get; set; }
    public string Name { get; set; }
    public Reaction Reaction { get; set; }
    public bool isSpeaking { get; set; }
    public int SuspicionLevel { get; set; }

    public void UpdateSuspicionLevel(int Change)
    {
        SuspicionLevel += Change;
    }
}
