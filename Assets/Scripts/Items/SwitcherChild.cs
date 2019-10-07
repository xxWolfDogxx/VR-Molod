using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitcherChild : MonoBehaviour
{
    [SerializeField] private bool isOneWay;

    public void Switch ()
    {
        var childCount = transform.childCount;
        for (var i = 0; i < childCount; i++)
        {
            var childGameObject = transform.GetChild(i).gameObject;
            if (!childGameObject.activeSelf) continue;
            if (i == childCount - 1 && isOneWay) continue;
            childGameObject.SetActive(false);
            var nextChildIndex = i == childCount - 1 ? 0 : i + 1;
            transform.GetChild(nextChildIndex).gameObject.SetActive(true);
            return;
        }
    }
}
