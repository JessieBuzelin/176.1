using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHydraBotOnBoss : MonoBehaviour
{
    public GameObject player;
    [SerializeField] private float shootTimer;
    public float shootInterval = 2f;
    protected Transform playerLocation;
    public GameObject hydraBotPrefab;
    public Transform HydraBossSpawn;
    public GameObject hydraBot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void spawnHydraBot()
    {
        hydraBot = Instantiate(hydraBotPrefab, HydraBossSpawn.position, HydraBossSpawn.rotation);
        hydraBot.GetComponent<TurretScript>().player = player.transform;

    }

    // Update is called once per frame
    void Update()
    {
        

        if (Vector3.Distance(transform.position, player.transform.position) < 30)
        {
            


            // Countdown timer

            shootTimer -= Time.deltaTime;

            if (shootTimer <= 0)
            {
                spawnHydraBot();

                shootTimer = shootInterval;
            }

        }
    }

    


}
