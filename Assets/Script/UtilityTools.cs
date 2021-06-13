using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class UtilityTools
{
    public static List<Slide> GenerateSlideListFromJSON()
    {
        string path = Application.streamingAssetsPath + "/SlideEntryList.json";
        string jsonString = System.IO.File.ReadAllText(path);
        SlideEntryList list = JsonUtility.FromJson<SlideEntryList>(jsonString);
        return list.SlideEntries;
    }
}
