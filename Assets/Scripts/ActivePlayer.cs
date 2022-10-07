using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ActivePlayer : MonoBehaviour
{
    private ActivePlayerManager manager; //Makes the players aware of existence of the Turn Manager 

    public Transform ballSpawnPoint;
    public Transform ballSpawnPointAngle;
    public GameObject ballPrefab;

    public void AssignManager(ActivePlayerManager theManager) //We are creating a function to retrieve another script and giving it a parameter to later be able to create a reference in this script. 
    {
        manager = theManager; //Doing this we can do later use this as a reference with dot operance to be able to retrive functions like ChangeTurn() into this script.
    }

    public void ShootBall(float ballSpeed)
    {
        var ball = Instantiate(ballPrefab, ballSpawnPoint.position, ballSpawnPoint.rotation);
        ball.GetComponent<Rigidbody>().velocity = ballSpawnPoint.forward * ballSpeed;
       //SetRandomColor();
        manager.ChangeTurn();

    }    
}
