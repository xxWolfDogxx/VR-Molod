using UnityEngine;
using System;
using UnityEngine.Events;

public class GameLoseManager : Singleton<GameLoseManager>
{
    [SerializeField] private Timer timer;
    public UnityEvent unityEvent;
    public Action GameLose;

    private void Awake()
    {
        timer.TimeIsOver += () =>
        {
            unityEvent.Invoke();
            if (GameLose != null) GameLose.Invoke();
        };
    }
}
