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

    public int AddHour = 0;

    DateTime date;

    void Start()
    {
        HourHandTransform = transform.Find("HourHand");
        MinuteHandTransform = transform.Find("MinuteHand");
        SecondHandTransform = transform.Find("SecondHand");
    }

    void Update()
    {
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
            HourHandTransform.eulerAngles = new Vector3(0, 0, date.Hour * DegreesPerHour);
            MinuteHandTransform.eulerAngles = new Vector3(0, 0, date.Minute * DegreesPerMinute);
            SecondHandTransform.eulerAngles = new Vector3(0, 0, date.Second * DegreesPerSecond);
        }
    }

}
