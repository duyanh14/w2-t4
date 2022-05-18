using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{

    const float DegreesPerHour = 30f;
    const float DegreesPerMinute = 6f;
    const float DegreesPerSecond = 6f;

    private Transform HourHandTransform;
    private Transform MinuteHandTransform;
    private Transform SecondHandTransform;

    public bool Continuous;

<<<<<<< HEAD
    private void Awake()
=======
    public int AddHour = 0;

    DateTime date;

    void Start()
>>>>>>> d122be9c7dd11235b4e21e63b29e2d6ed4e24cf9
    {
        HourHandTransform = transform.Find("HourHand");
        MinuteHandTransform = transform.Find("MinuteHand");
        SecondHandTransform = transform.Find("SecondHand");
<<<<<<< HEAD

        DateTime date = DateTime.Now;

        HourHandTransform.eulerAngles = new Vector3(0, 0, date.Hour * DegreesPerHour);
        MinuteHandTransform.eulerAngles = new Vector3(0, 0, date.Minute * DegreesPerMinute);
        SecondHandTransform.eulerAngles = new Vector3(0, 0, date.Second * DegreesPerSecond);
=======
>>>>>>> d122be9c7dd11235b4e21e63b29e2d6ed4e24cf9
    }

    void Update()
    {
<<<<<<< HEAD
        if (Continuous)
        {
            TimeSpan date = DateTime.Now.TimeOfDay;
            HourHandTransform.eulerAngles = new Vector3(0, 0, (float)date.TotalHours * DegreesPerHour);
            MinuteHandTransform.eulerAngles = new Vector3(0, 0, (float)date.TotalMinutes * DegreesPerMinute);
            SecondHandTransform.eulerAngles = new Vector3(0, 0, (float)date.TotalSeconds * DegreesPerSecond);
        }
        else
        {
            DateTime date = DateTime.Now;

=======
        date = DateTime.Now;
        if (AddHour > 0)
        {
            date = date.AddHours(AddHour);
        }
        if (Continuous)
        {
            HourHandTransform.eulerAngles = new Vector3(0, 0, (float)date.TimeOfDay.TotalHours * DegreesPerHour);
            MinuteHandTransform.eulerAngles = new Vector3(0, 0, (float)date.TimeOfDay.TotalMinutes * DegreesPerMinute);
            SecondHandTransform.eulerAngles = new Vector3(0, 0, (float)date.TimeOfDay.TotalSeconds * DegreesPerSecond);
        }
        else
        {
>>>>>>> d122be9c7dd11235b4e21e63b29e2d6ed4e24cf9
            HourHandTransform.eulerAngles = new Vector3(0, 0, date.Hour * DegreesPerHour);
            MinuteHandTransform.eulerAngles = new Vector3(0, 0, date.Minute * DegreesPerMinute);
            SecondHandTransform.eulerAngles = new Vector3(0, 0, date.Second * DegreesPerSecond);
        }
    }

}
