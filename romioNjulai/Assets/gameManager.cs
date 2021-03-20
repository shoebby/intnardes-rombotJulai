using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public string sceneName;
    public static string previousScene;
    public static int dayTracker = 1;
    public static int mercutioTracker = 1;
    public static int capuletTracker = 1;
    public static int montagueTracker = 1;
    public static int knowledgeableTracker = 1;

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
}
