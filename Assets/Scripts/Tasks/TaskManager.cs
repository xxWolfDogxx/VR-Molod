using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TaskManager : Singleton<TaskManager>
{
    public List<Task> Tasks;

    private void Awake()
    {
        Tasks = FindObjectsOfType<Task>().ToList();
    }
}