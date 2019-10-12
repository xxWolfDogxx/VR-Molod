using UnityEngine;
using UnityEngine.Events;

public class InteractableTarget : MonoBehaviour
{
    [SerializeField] private UnityEvent unityEvent;
    public bool IsPlayerWatchingOnMe { get; private set; }

    public void Interact ()
    {
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
    