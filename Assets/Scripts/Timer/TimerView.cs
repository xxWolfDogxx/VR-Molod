using System;
using UnityEngine;
using UnityEngine.UI;

public class TimerView : MonoBehaviour
{
    [SerializeField] private Timer timer;

    private void Awake()
    {
        if (timer == null) return;
        timer.TimeWasChanged += (time) =>
        {
            var t = TimeSpan.FromSeconds(time);
            GetComponent<Text>().text = string.Format("{0:D2}:{1:D2}", t.Minutes, t.Seconds);
        };
        timer.TimeIsOver += () =>
        {
            GetComponent<Text>().text = string.Empty;
        };
    }
}
