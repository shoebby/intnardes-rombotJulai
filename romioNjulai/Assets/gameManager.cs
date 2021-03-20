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
    //2 after leaving to capulet on day 1
    //3 after leaving to capulet on day 2
    //4 after leaving to montague on day 3
    //5 after leaving to botanical garden on day 4
    public static int capuletTracker = 1;
    //2 after doing tybalt's quest
    //3 after returning from junkyard
    //4 after returning from the missile silo
    public static int montagueTracker = 1;
    //2 after doing benvolio's quest
    //3 after returning from junkyard
    //4 after returning from the missile silo
    public static int knowledgeableTracker = 1;
    //2 after finding code in the junkyard
    //3 after finding code in the missile silo
    //4 after finding info in the server room

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

    public void ProgressMercutio()
    {
        mercutioTracker += 1;
    }

    public void ProgressCapulet()
    {
        capuletTracker += 1;
    }

    public void ProgressMontague()
    {
        montagueTracker += 1;
    }

    public void ProgressKnowledgeable()
    {
        knowledgeableTracker += 1;
    }
}
