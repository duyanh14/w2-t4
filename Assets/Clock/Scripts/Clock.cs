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

    private void Awake()
    {
        HourHandTransform = transform.Find("HourHand");
        MinuteHandTransform = transform.Find("MinuteHand");
        SecondHandTransform = transform.Find("SecondHand");

        DateTime date = DateTime.Now;

        HourHandTransform.eulerAngles = new Vector3(0, 0, date.Hour * DegreesPerHour);
        MinuteHandTransform.eulerAngles = new Vector3(0, 0, date.Minute * DegreesPerMinute);
        SecondHandTransform.eulerAngles = new Vector3(0, 0, date.Second * DegreesPerSecond);
    }

    void Update()
    {
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

            HourHandTransform.eulerAngles = new Vector3(0, 0, date.Hour * DegreesPerHour);
            MinuteHandTransform.eulerAngles = new Vector3(0, 0, date.Minute * DegreesPerMinute);
            SecondHandTransform.eulerAngles = new Vector3(0, 0, date.Second * DegreesPerSecond);
        }
    }

}
