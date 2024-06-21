using System.Collections;
using System.Collections.Generic;
using Unity.FPS.Game;
using UnityEngine;

public class SimpleDamageZone : HydraScript
{
    [SerializeField] float damage = 20;

    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<Health>())
        {
            other.GetComponent<Health>().TakeDamage(damage,gameObject);
        }
    }
}
