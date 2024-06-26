using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HydraScript : TurretScript
{
    public float moveSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        playerReference = FindObjectOfType<Player>();
    }

    


    // Update is called once per frame
    void Update()
    {
        ShootPlayer();
        LooksAtPlayer(playerReference.transform.position);

        if (player != null)
        {
            // Calculate direction towards the player
            Vector3 direction = player.position - transform.position;
            direction.Normalize();  // Normalize to get a unit direction vector

            // Move towards the player
            transform.position += direction * moveSpeed * Time.deltaTime;
        }
    }
}
