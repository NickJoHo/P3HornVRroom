using UnityEngine;
using System;

public class ClockScript : MonoBehaviour
{
    [SerializeField] private GameObject _handHour;
    [SerializeField] private GameObject _handMinute;
    [SerializeField] private GameObject _handSeconds;

    // Update is called once per frame

    private void OnEnable()
    {
        //SoundManager
    }
    void Update()
    {
        UpdateRealTimer();
    }
    private void UpdateRealTimer()
    {
        var currentTime = DateTime.Now;

        var secondsDegree = 360f / 60f;
        var minutesDegree = 360f / 60f;
        var hoursDegree = 360f / 12f;

        _handSeconds.transform.localRotation = Quaternion.Euler(new Vector3(0, secondsDegree * currentTime.Second, -0));
        _handMinute.transform.localRotation = Quaternion.Euler(new Vector3(0, minutesDegree * currentTime.Minute, -0));
        _handHour.transform.localRotation = Quaternion.Euler(new Vector3(0, hoursDegree * currentTime.Hour, -0));
    }
}