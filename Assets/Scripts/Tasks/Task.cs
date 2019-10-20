using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task : MonoBehaviour
{
    [SerializeField] private string _description;
    public string Description => _description;

    public bool IsCompleted { get; private set; }

    protected void Complete ()
    {
        IsCompleted = true;
    }
}
