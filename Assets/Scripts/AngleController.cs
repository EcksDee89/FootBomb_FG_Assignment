using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngleController : MonoBehaviour
{
    [SerializeField] private ActivePlayerManager manager;
    [SerializeField] public float rotationSpeed = 5;
    

    [SerializeField] public ActivePlayer owningPlayer;

    private void Update()
    {
        float rotation = rotationSpeed * Time.deltaTime;
        
        if (manager.PlayerCanPlay())
        {
            if (manager.GetCurrentPlayer() == owningPlayer)
            {
                if (Input.GetKey(KeyCode.E))
                {
                     transform.Rotate(rotation, 0, 0);
                }

                if (Input.GetKey(KeyCode.Q))
                {
                    transform.Rotate(-rotation, 0, 0);
                }
            }    
        }
    }
    public void RaiseAngle(float verticalAngle)
    {
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles +
            new Vector3(verticalAngle * rotationSpeed, 0, 0));
    }
}
