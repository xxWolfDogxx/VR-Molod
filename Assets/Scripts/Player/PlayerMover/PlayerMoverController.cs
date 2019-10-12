using UnityEngine;

public abstract class PlayerMoverController : MonoBehaviour
{
    protected void SetInputAxis (float dx, float dz)
    {
        var cameraTransform = Camera.main.transform;
        var dirX = NormalizedDirection(cameraTransform.forward) * dx;
        var dirZ = NormalizedDirection(cameraTransform.right) * dz;
        var moveDirection = (dirX + dirZ).normalized;
        GetComponent<PlayerMoverModel>().SetMoveDirection(moveDirection);
    }

    Vector3 NormalizedDirection(Vector3 direction)
    {
        direction.y = 0;
        direction.Normalize();
        return direction;
    }
}
