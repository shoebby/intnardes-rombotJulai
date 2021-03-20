using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class juliasTower : MonoBehaviour
{
    public GameObject capuletEnding;
    public GameObject montagueEnding;
    public GameObject mercutioEnding;
    public GameObject knowledgeableEnding;

    void Start()
    {
        if (gameManager.capuletTracker == 4)
        {
            capuletEnding.SetActive(true);
        } else if (gameManager.montagueTracker == 4)
        {
            montagueEnding.SetActive(true);
        } else if (gameManager.mercutioTracker == 5)
        {
            mercutioEnding.SetActive(true);
        } else if (gameManager.knowledgeableTracker == 4)
        {
            knowledgeableEnding.SetActive(true);
        }
    }
}
