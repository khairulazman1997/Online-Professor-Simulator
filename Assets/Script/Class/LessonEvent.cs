using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LessonEvent
{
    public Student StudentInvolved;
    public string WhatStudentSaid;
    public string ActionTaken;

    public LessonEvent(Student student, string said, string action)
    {
        StudentInvolved = student;
        WhatStudentSaid = said;
        ActionTaken = action;
    }
}
