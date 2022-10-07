using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    
    public float delay = 3f;

    public GameObject explosionEffect;

    float countdown;
    bool hasExploded = false;

    void Start()
    {
        countdown = delay;    
    }

    void Update()
    {
        countdown -= Time.deltaTime;
        if (countdown <= 0f)
            if (countdown <= 0f && !hasExploded)
        {
            Explode();
                hasExploded = true;
                Destroy(gameObject);    
            }
    }
    void Explode()
    {
        Debug.Log("BOOM");
        Instantiate(explosionEffect, transform.position, transform.rotation);
        CheckForPlayer();

        Destroy(gameObject);
        
    }
    //Looking for objects with ActivePlayerHealth in it to determine if it could take damage. Then deal the set damage.
    private void CheckForPlayer()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, 6f);
        foreach (Collider c in colliders)
        {
            if (c.GetComponent<ActivePlayerHealth>())
            {
                c.GetComponent<ActivePlayerHealth>().TakeDamage(20);
            }
        }
    }

    
}
