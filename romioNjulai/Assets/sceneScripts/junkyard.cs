using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class junkyard : MonoBehaviour
{
    public GameObject junkyardCapulet;
    public GameObject junkyardMontague;

    void Start()
    {
        if (gameManager.capuletTracker == 2)
        {
            junkyardCapulet.SetActive(true);
        } else if (gameManager.montagueTracker == 2)
        {
            junkyardMontague.SetActive(true);
        }
    }
}
