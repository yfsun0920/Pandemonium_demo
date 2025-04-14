using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string sceneName; // Set this in the inspector to the name of the next scene

    public void LoadNextScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
