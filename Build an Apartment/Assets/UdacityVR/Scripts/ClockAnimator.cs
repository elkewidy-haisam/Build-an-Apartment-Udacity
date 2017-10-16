using UnityEngine;
using System;

//The clock script is inspired by the Unity tutorial for animating clocks. The actual prefab, however, was downloaded from the Asset Store.
//This is mostly because I could not get the Udacity clock prefab, and its hands, to read the time from the system so it can operate in real time.
public class ClockAnimator : MonoBehaviour
{

    private const float
        hoursToDegrees = 360f / 12f,
        minutesToDegrees = 360f / 60f,
        secondsToDegrees = 360f / 60f;

    public Transform hours, minutes, seconds;
    public bool analog;

    void Update()
    {
        if (analog)
        {
            TimeSpan timespan = DateTime.Now.TimeOfDay;
            hours.localRotation =
                Quaternion.Euler(0f, 0f, (float)timespan.TotalHours * hoursToDegrees);
            minutes.localRotation =
                Quaternion.Euler(0f, 0f, (float)timespan.TotalMinutes * minutesToDegrees);
            seconds.localRotation =
                Quaternion.Euler(0f, 0f, (float)timespan.TotalSeconds * secondsToDegrees);
        }
        else
        {
            DateTime time = DateTime.Now;
            hours.localRotation = Quaternion.Euler(0f, 0f, time.Hour * hoursToDegrees);
            minutes.localRotation = Quaternion.Euler(0f, 0f, time.Minute * minutesToDegrees);
            seconds.localRotation = Quaternion.Euler(0f, 0f, time.Second * secondsToDegrees);
        }
    }
}
