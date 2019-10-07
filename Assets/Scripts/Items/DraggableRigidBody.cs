using System.Collections;
using UnityEngine;

public class DraggableRigidBody : MonoBehaviour
{
    [SerializeField] private float lerpFactor = 0.5f;

    public void Drag (Transform target)
    {
        StartCoroutine(LoopDrag(target));
    }

    public void Drop ()
    {
        StopCoroutine(LoopDrag());
    }

    private IEnumerator LoopDrag(Transform target = null)
    {
        while (true)
        {
            yield return null;
            transform.position = Vector3.Lerp(transform.position, target.position, lerpFactor);
        }
    }
}
