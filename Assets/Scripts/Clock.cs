using System;
using UnityEngine;

public class Clock : MonoBehaviour {
    
    // Transform object fields that correspond with the pivots in Unity
    [SerializeField] 
    Transform hoursPivot, minutesPivot, secondsPivot;

    // Float constants for pivot rotations so the time can be translated to rotation degree
    const float hoursToDegrees = -30f, minutesToDegrees = -6f, secondsToDegrees = -6f;

    // The Awake method will run once every frame that the Unity program is running; 
    // Every frame the pivots of the clock are updated to the current time
    void Update () {

        // Object that stores the current time
        TimeSpan time = DateTime.Now.TimeOfDay;

        // Sets the pivots to the current time
        hoursPivot.localRotation = Quaternion.Euler(0f, 0f, hoursToDegrees * (float) time.TotalHours);
        minutesPivot.localRotation = Quaternion.Euler(0f, 0f, minutesToDegrees * (float) time.TotalMinutes);
        secondsPivot.localRotation = Quaternion.Euler(0f, 0f, minutesToDegrees * (float) time.TotalSeconds);;

    }

}
