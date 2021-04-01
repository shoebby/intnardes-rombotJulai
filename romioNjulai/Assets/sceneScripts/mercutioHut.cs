using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mercutioHut : MonoBehaviour
{
    public GameObject NPCsDay1_morning;
    public GameObject NPCsDay1_evening;

    public GameObject NPCsDay2_morning;
    public GameObject NPCsDay2_evening;

    public GameObject NPCsDay3_morning;
    public GameObject NPCsDay3_evening;
    void Start()
    {
        //day 1
        if (gameManager.dayTracker == 1)
        {
            NPCsDay1_morning.SetActive(true);
        }
        else if (gameManager.dayTracker == 2)
        {
            NPCsDay1_evening.SetActive(true);
        }
        //day 2
        else if (gameManager.dayTracker == 3)
        {
            NPCsDay2_morning.SetActive(true);
        }
        else if (gameManager.dayTracker == 4)
        {
            NPCsDay2_evening.SetActive(true);
        }
        //day 3
        else if (gameManager.dayTracker == 5)
        {
            NPCsDay3_morning.SetActive(true);
        }
        else if (gameManager.dayTracker == 6)
        {
            NPCsDay3_evening.SetActive(true);
        }
    }
}
