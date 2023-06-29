using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public string nameScene;

     private void Start()
    {
        ChangeScene(nameScene);    
    }
    
    public void ChangeScene(string sceneName)
    {
        // Unload the current scene asynchronously
        SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
        // Load the new scene
        SceneManager.LoadScene(sceneName);
    }
}

