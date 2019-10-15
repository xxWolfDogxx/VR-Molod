using UnityEngine;

public class DraggableRigidBody : MonoBehaviour
{
    private bool isActiveDrag;

    public void Drag ()
    {
        isActiveDrag = true;
        GetComponent<DragRigidbody>().HandleInputBegin();
    }

    public void Drop ()
    {
        isActiveDrag = false;
        GetComponent<DragRigidbody>().HandleInputEnd();
    }

    private void Update()
    {
        if (isActiveDrag) GetComponent<DragRigidbody>().HandleInput();
    }
}
