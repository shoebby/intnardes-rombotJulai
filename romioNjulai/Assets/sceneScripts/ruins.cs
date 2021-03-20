using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ruins : MonoBehaviour
{
    public GameObject ruinsCapulet;
    public GameObject ruinsKnowledgeable;

    void Start()
    {
        if (gameManager.capuletTracker == 3)
        {
            ruinsCapulet.SetActive(true);
        }
        else if (gameManager.knowledgeableTracker == 3)
        {
            ruinsKnowledgeable.SetActive(true);
        }
    }
}
