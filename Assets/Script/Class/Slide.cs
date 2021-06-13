using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

[Serializable]
public class Slide
{
    public int ID;
    public Topic Topic;
    public int AllegianceModifier;
    public int AttentionModifier;
    public int SuspicionModifier;
}

[Serializable]
public class SlideEntryList
{
    public List<Slide> SlideEntries;
}
