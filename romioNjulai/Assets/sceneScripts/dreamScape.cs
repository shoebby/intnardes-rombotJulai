using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dreamScape : MonoBehaviour
{
    public GameObject dreamNight1;
    public GameObject dreamNight2;
    public GameObject dreamNight3;
    public GameObject dreamNight4;

    void Start()
    {
        if (gameManager.dayTracker == 1)
        {
            dreamNight1.SetActive(true);
        }
        else if (gameManager.dayTracker == 2)
        {
            dreamNight2.SetActive(true);
        }
        else if (gameManager.dayTracker == 3)
        {
            dreamNight3.SetActive(true);
        }
        else if (gameManager.dayTracker == 4)
        {
            dreamNight4.SetActive(true);
        }
    }
}
