using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitcherAnimation: MonoBehaviour
{
    private const string animationForward = "Forward";
    private const string animationBackward = "Backward";
    private bool isForward = true;

    public void Switch()
    {
        var trigger = isForward ? animationBackward : animationForward;
        GetComponent<Animator>().SetTrigger(trigger);
	    isForward = !isForward;
    }
}
