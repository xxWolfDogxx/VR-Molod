using System.Collections;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

public class GameVictoryManager : MonoBehaviour
{
    [SerializeField] private UnityEvent unityEventBefore = null;
    [SerializeField] private UnityEvent unityEventAfter = null;

    private void Start()
    {
        StartCoroutine(WaitForButton());
    }

    private IEnumerator WaitForButton ()
    {
        while (TaskManager.Instance.Tasks.Any(a => !a.IsCompleted) || PlayerInput.MainButtonHold)
        {
            yield return null;
        }
        unityEventBefore.Invoke();
        yield return new WaitForSeconds(1);
        while (true)
        {
            yield return null;
            if (PlayerInput.MainButtonUp) break;
        }
        unityEventAfter.Invoke();
    }
}
