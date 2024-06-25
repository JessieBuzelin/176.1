using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretScript : BaseEnemyScript
{
    [SerializeField] protected Transform playerLocation;
    [SerializeField] private float lookSpeed = 10f;
    public Transform player; // This will hold a reference to the player's Transform component
    // Start is called before the first frame update
    void Start()
    {
        playerReference = FindObjectOfType<Player>();
    }

    


    // Update is called once per frame
    void Update()
    {
        ShootPlayer(); 
        LooksAtPlayer(playerLocation.position);
    }
protected void LooksAtPlayer(Vector3 playerLocation)
{

        if (Vector3.Distance(transform.position, playerLocation) < 30) 
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
