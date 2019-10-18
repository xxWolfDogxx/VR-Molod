using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private float value;
    public Action<float> TimeWasChanged;
    public Action TimeIsOver;

    private void Update()
    {
        value -= Time.deltaTime;
        if (value < 0) value = 0;
        TimeWasChanged.Invoke(value);
        if (value != 0) return;
        TimeIsOver.Invoke();
        enabled = false;
    }
}
