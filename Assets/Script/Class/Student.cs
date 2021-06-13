using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Topic : int
{
    Science = 0,
    Math = 1,
    Geography = 2,
    Animals = 3,
    TheArts = 4,
    Music = 5,
    History = 6,
    Politics = 7
}

public enum Status: int
{
    Active = 0,
    Kicked = 1,
    Reported = 2,
    Gulaged = 3
}

public class Student : IPerson
{
    //IPerson Fields
    int IPerson.ID { get; set; }
    public string Name { get; set; }
    public Reaction Reaction { get; set; }
    public bool isSpeaking { get; set; }

    //Status
    public Status Status { get; set; }

    //Variable Affecting Fields
    /// <summary>
    /// Topics students is interested in. 1.2x Multiplier
    /// if slides match this, 0.8 x if conflicting and 
    /// 1x otherwise.
    /// </summary>
    public Topic Interest { get; private set; }
    /// <summary>
    /// Grants a 1.2x multiplier to positive modifier to current 
    /// allegiance and 0.8x for negative modifier.
    /// </summary>
    public int Loyalty;
    /// <summary>
    /// Positive represents pro-state sentiments and negative represents
    /// anti-state sentiments. Maxes out at 1000
    /// </summary>
    public int Allegiance { get; set; }
    public Opinion Opinion;

    //Image IDs
    public int HairID;
    public int FaceID;
    public int BodyID;
    
    public Student()
    {
        //TODO: Get a name list
        Name = "Lol";
        Reaction = 0;
        isSpeaking = false;
        Status = Status.Active;

        int interest = (int) (System.Enum.GetValues(typeof(Topic)).Length * Random.value);
        Interest = (Topic) interest;

        //TODO: Set Loyalty
        Loyalty = 1;

        Allegiance = (int) (2000 * Random.value) - 1000;
        Opinion = CalculateOpinion();

        HairID = (int)(8 * Random.value);
        FaceID = (int)(8 * Random.value);
        BodyID = (int)(8 * Random.value);
    }
    public void UpdateAllegiance(float attentionMultiplier, int allegianceModifier, Topic topic)
    {
        int change;
        Debug.Log(attentionMultiplier);
        //Check whether topic is Student's interest
        if (Mathf.Abs((int)topic - (int)Interest) == 4)
        {
            change = (int)(allegianceModifier * attentionMultiplier * 0.8);
        } else if (topic == Interest)
        {
            change = (int)(allegianceModifier * attentionMultiplier * 1.2);
        } else
        {
            change = (int)(allegianceModifier * attentionMultiplier);
        }
        Debug.Log(change);
        Allegiance = Mathf.Min(Allegiance + change, 1000);
        Allegiance = Mathf.Max(Allegiance, -1000);
        Opinion = CalculateOpinion();
    }

    public void UpdateAllegiance(int allegianceModifier)
    {
        Allegiance = Mathf.Min(Allegiance + allegianceModifier, 1000);
        Allegiance = Mathf.Max(Allegiance, -1000);
        Opinion = CalculateOpinion();
    }

    private Opinion CalculateOpinion()
    {
        if (Allegiance > 0)
        {
            return Opinion.Pro;
        } else if (Allegiance < 0)
        {
            return Opinion.Anti;
        }
        return Opinion.Neutral;
    }
}
