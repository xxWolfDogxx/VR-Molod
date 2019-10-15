using UnityEngine;

public class PlayerHand : MonoBehaviour
{
    [SerializeField] private PlayerControllerForInteractableTarget playerControllerForInteractableTarget;
    private DraggableRigidBody draggableRigidBodyCurrent;

    void Update()
    {
        PickDrop();
    }

    private void PickDrop()
    {
        if (PlayerInput.MainButtonDown)
        {
            print("GRAB");
            var currentTarget = playerControllerForInteractableTarget.ItemTargetCurrent;
            if (currentTarget == null) return;
            draggableRigidBodyCurrent = currentTarget.GetComponent<DraggableRigidBody>();
            if (draggableRigidBodyCurrent == null) return;
            draggableRigidBodyCurrent.Drag();
            playerControllerForInteractableTarget.LockFocus();
        }
        if (PlayerInput.MainButtonUp)
        {
            print("DROP");
            if (draggableRigidBodyCurrent == null) return;
            draggableRigidBodyCurrent.Drop();
            draggableRigidBodyCurrent = null;
            playerControllerForInteractableTarget.UnlockFocus();
        }
    }
}
