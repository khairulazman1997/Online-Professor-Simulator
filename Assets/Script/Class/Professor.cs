using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Professor : IPerson
{
    int IPerson.ID { get; set; }
    public string Name { get; set; }
    public Reaction Reaction { get; set; }
    public bool isSpeaking { get; set; }
    public int SuspicionLevel { get; set; }

    public int Allegiance { get; set; }

    public Professor()
    {
        Name = "Mulberry";
        Reaction = 0;
        isSpeaking = false;
        SuspicionLevel = 0;
        Allegiance = 0;
    }

    public void UpdateSuspicionLevel(int Change)
    {
        SuspicionLevel += Change;
    }
}
