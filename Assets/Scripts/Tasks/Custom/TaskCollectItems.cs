using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskCollectItems : Task
{
    [SerializeField] private int amount = 0;
    private List<Collider> items = new List<Collider>();

    private void OnTriggerEnter (Collider collider)
    {
        if (collider.tag != gameObject.tag) return;
        items.Add(collider);
        if (items.Count == amount) Complete();
    }

    private void OnTriggerExit(Collider collider)
    {
        if (collider.tag != gameObject.tag) return;
        items.Remove(collider);
    }
}
