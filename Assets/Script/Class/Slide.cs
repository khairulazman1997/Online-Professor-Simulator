using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

[Serializable]
public class Slide
{
    // Slide Fields
    public int ID;
    public Topic Topic;
    public int AllegianceModifier;
    public int AttentionModifier;
    public int SuspicionModifier;

    // Opinion Fields
    public string ProOpinion;
    public string AntiOpinion;
    public string NeutralOpinion;

    public Opinion Opinion;

}

[Serializable]
public class SlideEntryList
{
    public List<Slide> SlideEntries;
}

public enum Opinion: int
{
    None = 0,
    Pro = 1,
    Anti = 2,
    Neutral = 3
}
