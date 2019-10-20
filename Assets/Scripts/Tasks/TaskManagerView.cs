using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskManagerView : MonoBehaviour
{
    [SerializeField] private Text textResult;

    public void ShowResult ()
    {
        var text = string.Empty;
        var tasks = TaskManager.Instance.Tasks;
        foreach (var task in tasks)
        {
            var result = task.IsCompleted ? "<color=green> Завершено </color>" : "<color=red> Не выполнено </color>";
            text += task.Description + ": " + result + "\n";
        }
        textResult.text = text;
        textResult.enabled = true;
        GetComponent<Animator>().SetTrigger("In");
    }

    public void HideResult ()
    {
        GetComponent<Animator>().SetTrigger("Out");
    }
}
