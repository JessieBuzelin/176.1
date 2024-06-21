using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HydraScript : TurretScript
{
    public float moveSpeed = 5f;
    [SerializeField] protected Transform playerLocation;
    [SerializeField] private float lookSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        playerReference = FindObjectOfType<Player>();
    }

    public Transform player; // This will hold a reference to the player's Transform component


    // Update is called once per frame
    void Update()
    {
        ShootPlayer();
        LooksAtPlayer(playerLocation.position);

        if (player != null)
        {
            // Calculate direction towards the player
            Vector3 direction = player.position - transform.position;
            direction.Normalize();  // Normalize to get a unit direction vector

            // Move towards the player
            transform.position += direction * moveSpeed * Time.deltaTime;
        }
    }
    protected void LooksAtPlayer(Vector3 playerLocation)
    {

        if (Vector3.Distance(transform.position, playerLocation) < 10)
        {
            Quaternion targetRotation = Quaternion.LookRotation(playerLocation - transform.position);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, lookSpeed * Time.deltaTime);
        }

    }

    protected void ShootPlayer() // looks at player and shoots
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
