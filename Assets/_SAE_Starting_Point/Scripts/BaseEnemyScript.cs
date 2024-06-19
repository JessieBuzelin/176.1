using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEnemyScript : MonoBehaviour
{
    protected Player playerReference;

    // Start is called before the first frame update
    void Start()
    {
        playerReference = FindObjectOfType<Player>();  
        if (playerReference != null)
        {
            Debug.Log("Player object found: " + playerReference.name);
        }
        else
        {
            Debug.LogWarning("Player object not found!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        

        if (playerReference)
        {
            if (Vector3.Distance(transform.position, playerReference.transform.position) < 1)
            {
                Debug.Log("Player is close");

            }
        }
    }
}
