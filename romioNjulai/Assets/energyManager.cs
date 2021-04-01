using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class energyManager : MonoBehaviour
{
    public static int energy = 3;
    public static int energyPrice = 0;
    public GameObject[] energyBars;
    public bool energyChange = false;
    public string sceneName;

    void Start()
    {
        //for (int i = 0; i < 3; i++)
        //{
        //    energyBars[i].SetActive(false);
        //}

        //for (int i = 0; i < energy; i++)
        //{
        //    energyBars[i].SetActive(true);
        //}
    }

    private void Update()
    {
        //Debug.Log(energy);
        //Debug.Log(energyPrice);
        
        if (energyChange)
        {
            for (int i = 0; i < 3; i++)
            {
                energyBars[i].SetActive(false);
            }

            for (int i = 0; i < energy; i++)
            {
                energyBars[i].SetActive(true);
            }

            energyChange = false;
        }
    }

    public void ChangePrice(int newPrice)
    {
        energyPrice = newPrice;
    }

    public void ChangeScene(string sceneName)
    {
        if (energy >= energyPrice)
        {
            energy -= energyPrice;
            energyChange = true;
            SceneManager.LoadScene(sceneName);
        }
    }

    public void LowerEnergy()
    {
        if (energy >= 1)
        {
            energy -= 1;
            energyChange = true;
        }
    }
}
