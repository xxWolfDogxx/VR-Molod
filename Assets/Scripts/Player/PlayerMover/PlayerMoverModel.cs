using UnityEngine;

public class PlayerMoverModel : MonoBehaviour
{
    [SerializeField] private float speed = 0.02f;
    private Vector3 moveDirection;

    public void SetMoveDirection (Vector3 moveDirection)
    {
        this.moveDirection = moveDirection;
    }

    private void FixedUpdate()
    {
        GetComponent<Rigidbody>().MovePosition(transform.position + moveDirection * speed);
    }
}
