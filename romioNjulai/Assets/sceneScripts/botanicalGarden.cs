using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botanicalGarden : MonoBehaviour
{
    public GameObject friarLawrence;
    public GameObject nurse;
    public GameObject benvolio;
    public GameObject nature;

    void Start()
    {
        if (gameManager.capuletTracker == 4)
        {
            nurse.SetActive(true);
        } else if (gameManager.knowledgeableTracker == 4)
        {
            nature.SetActive(true);
        } else if (gameManager.mercutioTracker == 4)
        {
            friarLawrence.SetActive(true);
        } else if (gameManager.montagueTracker == 4)
        {
            benvolio.SetActive(true);
        }
    }
}
