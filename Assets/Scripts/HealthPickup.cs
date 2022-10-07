using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    
    private ActivePlayerHealth playerHealth;
    public float healingAmount = 20f;

    
    void OnTriggerEnter(Collider other)
    {
        ActivePlayerHealth playerHealth = other.GetComponent<ActivePlayerHealth>();
        if (playerHealth != null)
        {
            playerHealth.HealDamage(20);
            Destroy(gameObject);
        }
        

        
    }
}
