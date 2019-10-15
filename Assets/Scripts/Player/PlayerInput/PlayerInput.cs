using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public static bool MainButtonDown { get; set; }
    public static bool MainButtonUp { get; set; }
    public static bool MainButtonHold { get; set; }

    private void Update()
    {
        if (MainButtonDown) FindObjectOfType<TextMesh>().text = "Press";
        if (MainButtonUp) FindObjectOfType<TextMesh>().text = "Unpress";
    }
}
