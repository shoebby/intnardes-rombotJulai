using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missileSilo : MonoBehaviour
{
    public GameObject missileSiloCapulet;
    public GameObject missileSiloMontague;
    public GameObject missileSiloMercutio;
    public GameObject missileSiloKnowledgeable;

    void Start()
    {
        if (gameManager.capuletTracker == 3)
        {
            missileSiloCapulet.SetActive(true);
        }
        else if (gameManager.montagueTracker == 3)
        {
            missileSiloMontague.SetActive(true);
        }
        else if (gameManager.mercutioTracker == 4)
        {
            missileSiloMercutio.SetActive(true);
        }
        else if (gameManager.knowledgeableTracker == 2)
        {
            missileSiloKnowledgeable.SetActive(true);
        }
    }
}
