using System.Linq;
using UnityEngine;

public class PlayerControllerForInteractableTarget : MonoBehaviour
{
    [SerializeField] private KeyCode keyCode = KeyCode.Mouse0;

    void Update()
    {
        var result = Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out var hit, 3f);
        if (!result) return;

        var itemTarget = hit.transform.GetComponent<InteractableTarget>();
        if (itemTarget == null) return;

        if (Input.GetKeyDown(keyCode)) itemTarget.Interact();
    }
}
