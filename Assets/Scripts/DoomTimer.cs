using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoomTimer : MonoBehaviour
{
    //Killing the explosive prefab after it's duration's been played
    
    void Start()
    {
        var particle = gameObject.GetComponent<ParticleSystem>();
        Destroy(gameObject, particle.main.duration);
    }

}
