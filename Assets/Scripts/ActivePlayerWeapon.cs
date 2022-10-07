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

    

    //public float GetDamage()
    //{
    //    if(currentWeapon != null)
    //    {
    //        currentWeapon.GetDamage();
    //    }
    //    return weaponDamage;
    //}


    void Update()
    {
        
        
    }
    //public void ShootingBall()
    //{
    //    var ball = Instantiate(ballPrefab, ballSpawnPoint.position, ballSpawnPoint.rotation);
    //    ball.GetComponent<Rigidbody>().velocity = ballSpawnPoint.forward * ballSpeed;
    //    manager.ChangeTurn();
    //}
    public void setmanager(ActivePlayerManager theManager)
    {
        manager = theManager;
    }
}
