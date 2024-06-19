using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEnemyScript : MonoBehaviour
{
    protected Player playerReference;
    public int Speed = 10;

    // Start is called before the first frame update
    void Start()
    {
        playerReference = FindObjectOfType<Player>();  
    }

    // Update is called once per frame
    void Update()
    {
        

        if (playerReference)
        {
            if (Vector3.Distance(transform.position, playerReference.transform.position) < 5)
            {
                Debug.Log("Player is close");
            }
        }
    }
}
