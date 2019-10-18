using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitcherAnimation: MonoBehaviour
{
    [SerializeField] private string animationForward;
    [SerializeField] private string animationBackward;
    [SerializeField] private bool isBackwardState;

    public void Switch()
    {
        var trigger = isBackwardState ? animationForward : animationBackward;
        GetComponent<Animator>().SetTrigger(trigger);
        isBackwardState = !isBackwardState;
    }
}
