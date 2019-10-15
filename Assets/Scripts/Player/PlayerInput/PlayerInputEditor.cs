using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputEditor : MonoBehaviour
{
    private void Awake()
    {
        enabled = Application.isEditor;
    }

    private void Update()
    {
        PlayerInput.MainButtonDown = Input.GetKeyDown(KeyCode.Space);
        PlayerInput.MainButtonUp = Input.GetKeyUp(KeyCode.Space);
        PlayerInput.MainButtonHold = Input.GetKey(KeyCode.Space);
    }
}