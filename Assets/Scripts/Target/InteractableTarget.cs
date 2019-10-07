using UnityEngine;
using UnityEngine.Events;

public class InteractableTarget : MonoBehaviour
{
    [SerializeField] private UnityAction unityAction;

    public void Interact ()
    {
        unityAction.Invoke();
    }
}
    