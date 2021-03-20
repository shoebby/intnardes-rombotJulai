using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class montagueBase : MonoBehaviour
{
    public GameObject NPCsDay1_morning;
    public GameObject NPCsDay1_evening;
    public GameObject NPCsDay1_mercutio;

    public GameObject NPCsDay2_morning;
    public GameObject NPCsDay2_evening;
    public GameObject NPCsDay2_unAllied;
    public GameObject NPCsDay2_mercutio;

    public GameObject NPCsDay3_morning;
    public GameObject NPCsDay3_evening;
    public GameObject NPCsDay3_unAllied;
    public GameObject NPCsDay3_mercutio;

    public GameObject NPCsDay4_allied;
    public GameObject NPCsDay4_unAllied;

    void Start()
    {
        //day 1
        if (gameManager.dayTracker == 1 && gameManager.montagueTracker == 1)
        {
            NPCsDay1_morning.SetActive(true);
        }
        else if (gameManager.dayTracker == 1 && gameManager.montagueTracker == 2)
        {
            NPCsDay1_evening.SetActive(true);
        }
        else if (gameManager.dayTracker == 1 && gameManager.mercutioTracker == 2)
        {
            NPCsDay1_mercutio.SetActive(true);
        }
        //day 2
        else if (gameManager.dayTracker == 2 && gameManager.montagueTracker == 2)
        {
            NPCsDay2_morning.SetActive(true);
        }
        else if (gameManager.dayTracker == 2 && gameManager.montagueTracker == 1)
        {
            NPCsDay2_unAllied.SetActive(true);
        }
        else if (gameManager.dayTracker == 2 && gameManager.montagueTracker == 3)
        {
            NPCsDay2_evening.SetActive(true);
        }
        else if (gameManager.dayTracker == 2 && gameManager.mercutioTracker == 3)
        {
            NPCsDay2_mercutio.SetActive(true);
        }
        //day 3
        else if (gameManager.dayTracker == 3 && gameManager.montagueTracker == 3)
        {
            NPCsDay3_morning.SetActive(true);
        }
        else if (gameManager.dayTracker == 3 && gameManager.montagueTracker == 1)
        {
            NPCsDay3_unAllied.SetActive(true);
        }
        else if (gameManager.dayTracker == 3 && gameManager.montagueTracker == 4)
        {
            NPCsDay3_evening.SetActive(true);
        }
        else if (gameManager.dayTracker == 3 && gameManager.mercutioTracker == 4)
        {
            NPCsDay2_mercutio.SetActive(true);
        }
        //day 4
        else if (gameManager.dayTracker == 4 && gameManager.montagueTracker == 4)
        {
            NPCsDay4_allied.SetActive(true);
        }
        else if (gameManager.dayTracker == 4 && gameManager.montagueTracker == 1)
        {
            NPCsDay4_unAllied.SetActive(true);
        }
        else
        {

        }
    }
}
