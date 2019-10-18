using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class InteractableTarget : MonoBehaviour
{
    [SerializeField] private UnityEvent unityEvent;
    [SerializeField] private float delay;
    public bool IsPlayerWatchingOnMe { get; private set; }

    public void Interact ()
    {
        StopAllCoroutines();
        StartCoroutine(Delay());
    }

    private IEnumerator Delay ()
    {
        yield return new WaitForSeconds(delay);
        unityEvent.Invoke();
    }

    public void Watch ()
    {
        IsPlayerWatchingOnMe = true;
    }

    public void Unwatch ()
    {
        IsPlayerWatchingOnMe = false;
    }
}
    