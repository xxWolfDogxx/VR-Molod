using UnityEngine;
using UnityEngine.UI;

public class PlayerMoveController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 0.015f;
    [SerializeField] private float x0;
    [SerializeField] private float xM;
    [SerializeField] private float x1;
    [SerializeField] private float y0;
    [SerializeField] private float yM;
    [SerializeField] private float y1;

    [SerializeField] private TextMesh textMesh;
    [SerializeField] private TextMesh textMesh1;

    private void FixedUpdate()
    {
        var inputDirectionX = GetInput(Input.mousePosition.x, x0, x1, xM);
        var inputDirectionY = GetInput(Input.mousePosition.y, y0, y1, yM);
        textMesh.text = inputDirectionX.ToString();
        textMesh1.text = inputDirectionY.ToString();
        ////print("x" + inputDirectionX);
        //print("y" + inputDirectionY);
        var cameraTransform = Camera.main.transform;
        var dirX = NormalizedDirection(cameraTransform.forward) * inputDirectionX;
        var dirY = NormalizedDirection(cameraTransform.right) * inputDirectionY;
        var moveDirection = (dirX + dirY).normalized * moveSpeed;
        GetComponent<Rigidbody>().MovePosition(transform.position + moveDirection);

        Vector3 NormalizedDirection (Vector3 direction)
        {
            direction.y = 0;
            direction.Normalize();
            return direction;
        }
    }
    private float GetInput (float a, float a0, float a1, float aM)
    {
        var d = aM - a;
        var q = d / (a1 - a0);
        return q * 2;
    }
}
