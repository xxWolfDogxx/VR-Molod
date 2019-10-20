using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameRestartManager : MonoBehaviour
{
    private bool isRestartAvaible;
    public UnityEvent unityEvent;

    private void Awake()
    {
        GameLoseManager.Instance.GameLose += () =>
        {
            StartCoroutine(DelayRestart());
        };

        IEnumerator DelayRestart () 
        {
            yield return new WaitForSeconds(1);
            isRestartAvaible = true;
        }
    }

    private void Update()
    {
        if (!PlayerInput.MainButtonUp) return;
        if (!isRestartAvaible) return;
        isRestartAvaible = false;
        unityEvent.Invoke();
    }

    public void ForceRestart()
    {
        unityEvent.Invoke();
    }
}
