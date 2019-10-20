using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public void Load (string levelName)
    {
        SceneManager.LoadScene(levelName);
    }

    public void LoadCurrent ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
