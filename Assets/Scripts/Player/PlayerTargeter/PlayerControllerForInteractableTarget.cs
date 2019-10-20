using System.Linq;
using UnityEngine;

public class PlayerControllerForInteractableTarget : MonoBehaviour
{
    public InteractableTarget ItemTargetCurrent { get; private set; }
    private bool isFocusLocked;

    public void LockFocus()
    {
        isFocusLocked = true;
    }

    public void UnlockFocus()
    {
        isFocusLocked = false;
    }

    void Update()
    {
        if (isFocusLocked) return;
        InteractableTarget itemTarget = null;
        var hits = Physics.RaycastAll(transform.position, transform.TransformDirection(Vector3.forward)).OrderBy(a => a.distance);
        foreach (var hit in hits)
        {
            itemTarget = hit.transform.GetComponentInChildren<InteractableTarget>();
            if (itemTarget)
            { 
                if (!itemTarget.enabled) itemTarget = null;
                else break;
            }
        }

        if (itemTarget == null)
        {
            LoseFocusItem();
            return;
        }

        CheckIfTargetIsDifferent();
        if (PlayerInput.MainButtonDown) itemTarget.GetComponentsInChildren<InteractableTarget>().ToList().ForEach(a => a.Interact());

        void CheckIfTargetIsDifferent ()
        {
            if (itemTarget != ItemTargetCurrent)
            {
                if (ItemTargetCurrent) ItemTargetCurrent.Unwatch();
                if (itemTarget) itemTarget?.Watch();
            }
            ItemTargetCurrent = itemTarget;
        }

        void LoseFocusItem ()
        {
            if (ItemTargetCurrent) ItemTargetCurrent.Unwatch();
            ItemTargetCurrent = null;
        }
    }
}
