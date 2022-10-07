using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivePlayerWeapon : MonoBehaviour
{
    private ActivePlayerManager manager;
    [SerializeField] private float ballDamage;
    public Transform ballSpawnPoint;
    public GameObject ballPrefab;
    private float ballSpeed = 10f;

    public void setmanager(ActivePlayerManager theManager)
    {
        manager = theManager;
    }
}
