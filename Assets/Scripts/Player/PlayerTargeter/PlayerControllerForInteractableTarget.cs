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

        var result = Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out var hit, 2f);
        if (!result)
        {
            LoseFocusItem();
            return;
        }

        var itemTarget = hit.transform.GetComponentInChildren<InteractableTarget>();
        if (itemTarget == null)
        {
            LoseFocusItem();
            return;
        }

        CheckIfTargetIsDifferent();
        if (PlayerInput.MainButtonDown) itemTarget.Interact();

        void CheckIfTargetIsDifferent ()
        {
            if (itemTarget != ItemTargetCurrent)
            {
                ItemTargetCurrent?.Unwatch();
                itemTarget?.Watch();
            }
            ItemTargetCurrent = itemTarget;
        }

        void LoseFocusItem ()
        {
            ItemTargetCurrent?.Unwatch();
            ItemTargetCurrent = null;
        }
    }
}
