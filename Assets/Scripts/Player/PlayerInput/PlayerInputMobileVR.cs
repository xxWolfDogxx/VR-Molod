using UnityEngine;

public class PlayerInputMobileVR : MonoBehaviour
{
    private void Awake()
    {
        enabled = Application.isMobilePlatform;
    }

    private void Update()
    {
        PlayerInput.MainButtonDown = OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger);
        PlayerInput.MainButtonUp = OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger);
        PlayerInput.MainButtonHold = OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger);
    }
}
