using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public string sceneName;
    public static string previousScene;
    public static int dayTracker = 1;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
        }
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void SetPreviousScene()
    {
        Scene scene = SceneManager.GetActiveScene();
        previousScene = scene.name;
        Debug.Log(previousScene);
    }

    public void LoadPreviousScene()
    {
        SceneManager.LoadScene(previousScene);
    }

    public void NextDay()
    {
        dayTracker += 1;
    }
}
