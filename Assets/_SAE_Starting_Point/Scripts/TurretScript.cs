using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretScript : BaseEnemyScript
{
    // Start is called before the first frame update
    void Start()
    {
        playerReference = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Hello World!.");
        ShootPlayer();
    }


    protected void ShootPlayer()
    {
        if (playerReference)
        {
            if (Vector3.Distance(transform.position, playerReference.transform.position) < 10)
            {
                Debug.Log("Shoots Player");
            }
        }
    }
}
