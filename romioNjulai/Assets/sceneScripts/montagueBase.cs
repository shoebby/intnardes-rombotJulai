using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class montagueBase : MonoBehaviour
{
    public GameObject NPCsDay1_mercutio;

    public GameObject NPCsDay2_mercutio;

    public GameObject NPCsDay3_mercutio;

    void Start()
    {
        //day 1
        if (gameManager.dayTracker == 1)
        {
            NPCsDay1_mercutio.SetActive(true);
        }
        //day 2
        else if (gameManager.dayTracker == 3)
        {
            NPCsDay2_mercutio.SetActive(true);
        }
        //day 3
        else if (gameManager.dayTracker == 5)
        {
            NPCsDay2_mercutio.SetActive(true);
        }
    }
}
