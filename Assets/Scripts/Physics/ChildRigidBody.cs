using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildRigidBody : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Platform") return;
        transform.SetParent(collision.transform);
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag != "Platform") return;
        transform.SetParent(null);
    }
}
