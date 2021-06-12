using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Topic : int
{
    Science = 0,
    Politics = 1,
    Economy = 2
}
public class Student : MonoBehaviour, IPerson
{
    //IPerson Fields
    int IPerson.ID { get; set; }
    public string Name { get; set; }
    public Reaction Reaction { get; set; }
    public bool isSpeaking { get; set; }
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
    public int Allegiance;

    //Image IDs
    public int HairID;
    public int FaceID;
    public int BodyID;
    
    public void UpdateAllegiance()
    {
        //TODO: Add multiplier and calculations
    }
}
