using UnityEngine;

public class PlayerMoverControllerMobileVR : PlayerMoverController
{
    private void Awake()
    {
        enabled = Application.isMobilePlatform;
    }

    private void Update()
    {
        var v2 = OVRInput.Get(OVRInput.Axis2D.PrimaryTouchpad);
        SetInputAxis(v2.y, v2.x);
    }
}
