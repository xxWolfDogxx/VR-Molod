using UnityEngine;

public class PlayerMoverControllerEditor : PlayerMoverController
{
    private void Awake()
    {
        enabled = Application.isEditor;
    }

    private void Update()
    {
        SetInputAxis(Input.GetAxis("Vertical"), Input.GetAxis("Horizontal"));
    }
}
