using System.Linq;
using UnityEngine;

public class PlayerControllerForInteractableTarget : MonoBehaviour
{
    [SerializeField] private KeyCode keyCode = KeyCode.Mouse0;
    private InteractableTarget itemTargetOld = null;

    void Update()
    {
        var result = Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out var hit, 3f);
        if (!result) return;

        var itemTarget = hit.transform.GetComponent<InteractableTarget>();
        CheckIfTargetIsDifferent();
        if (itemTarget == null) return;

        if (Input.GetKeyDown(keyCode)) itemTarget.Interact();

        void CheckIfTargetIsDifferent ()
        {
            if (itemTarget != itemTargetOld)
            {
                itemTargetOld?.Unwatch();
                itemTarget?.Watch();
            }
            itemTargetOld = itemTarget;
        }
    }
}
