using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDamageZoneOnTurret : SimpleDamageZone
{
    public GameObject player;
    public GameObject projectilePrefab;
    public Transform firePoint;
    public float shootInterval = 2f;  // Time interval between shots
    public float projectileSpeed = 10f;

    private float shootTimer;

    void Start()
    {
        shootTimer = shootInterval;
    }

    void Update()
    {
        // Calculate direction towards the player
        Vector3 directionToPlayer = player.transform.position - transform.position;
        Quaternion rotationToPlayer = Quaternion.LookRotation(directionToPlayer);

        // Rotate enemy to face the player (optional)
        transform.rotation = rotationToPlayer;

        // Countdown timer
        shootTimer -= Time.deltaTime;

        shootTimer -= Time.deltaTime;

        if (shootTimer <= 0)
        {
            Shoot();
            shootTimer = shootInterval;
        }
    }

    void Shoot()
    {
        GameObject projectile = Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
        Rigidbody rb = projectile.GetComponent<Rigidbody>();

        if (rb != null)
        {
            rb.velocity = firePoint.forward * projectileSpeed;
        }
    }
}
