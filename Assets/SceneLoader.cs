using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadSceneByIndex()
    {
        SceneManager.LoadScene(2);
    }
}
