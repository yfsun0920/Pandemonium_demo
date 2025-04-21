using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnClick : MonoBehaviour
{
    public string sceneName; // assign in the Inspector

    void OnMouseDown()
    {
        SceneManager.LoadScene(sceneName);
    }
}
