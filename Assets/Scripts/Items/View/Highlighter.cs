using UnityEngine;

[RequireComponent(typeof(Outline))]
public class Highlighter : MonoBehaviour
{
    private void Update()
    {
        GetComponent<Outline>().enabled = GetComponent<InteractableTarget>().IsPlayerWatchingOnMe;
    }
}
