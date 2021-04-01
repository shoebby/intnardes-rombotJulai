using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dreamScape : MonoBehaviour
{
    public GameObject dreamNight1;
    public GameObject dreamNight2;
    public GameObject dreamNight3;

    void Start()
    {
        if (gameManager.dayTracker == 2)
        {
            dreamNight1.SetActive(true);
        }
        else if (gameManager.dayTracker == 4)
        {
            dreamNight2.SetActive(true);
        }
        else if (gameManager.dayTracker == 6)
        {
            dreamNight3.SetActive(true);
        }
    }
}
