using System.Collections;
using UnityEngine;

public class DraggableRigidBody : MonoBehaviour
{
    public bool isActiveDrag;

    public void Drag ()
    {
        isActiveDrag = true;
        GetComponent<DragRigidbody>().HandleInputBegin();
    }

    public void Drop ()
    {
        isActiveDrag = false;
        GetComponent<DragRigidbody>().HandleInputEnd();
        StartCoroutine(Wait());
    }

    private IEnumerator Wait ()
    {
        GetComponent<Rigidbody>().isKinematic = true;
        yield return null;
        GetComponent<Rigidbody>().isKinematic = false;
    }

    private void Update()
    {
        if (isActiveDrag) GetComponent<DragRigidbody>().HandleInput();
    }
}
