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
}

[Serializable]
public class SlideEntryList
{
    public List<Slide> SlideEntries;
}
