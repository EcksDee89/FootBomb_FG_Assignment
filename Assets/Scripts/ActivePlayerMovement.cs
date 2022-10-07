using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivePlayerMovement : MonoBehaviour
{
    [SerializeField] private ActivePlayerManager manager;
    [SerializeField] private float rotationSpeed;
    [SerializeField] private float walkingSpeed;

    
    void Update()
    {
        if (manager.PlayerCanPlay())
        {

            

            float translation = Input.GetAxis("Vertical") * walkingSpeed * Time.deltaTime;
            float rotation = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;

            manager.GetCurrentPlayer().transform.Translate(0, 0, translation);
            manager.GetCurrentPlayer().transform.Rotate(0, rotation, 0);
        }
        // Commented for future use and learning
        //if (Input.GetAxis("Horizontal") != 0)
        //{
        //    ActivePlayer currentPlayer = manager.GetCurrentPlayer();
        //    //Julianas
        //    currentPlayer.transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime * Input.GetAxis("Horizontal"), Space.World);
        //    currentPlayer.transform.Translate(transform.right * walkingSpeed * Time.deltaTime * Input.GetAxis("Horizontal"), Space.World);
            
        //} 
        //if (Input.GetAxis("Vertical") != 0)
        //{
        //    ActivePlayer currentPlayer = manager.GetCurrentPlayer();
        //    //Julianas
        //     currentPlayer.transform.Translate(currentPlayer.transform.forward * walkingSpeed * Time.deltaTime * Input.GetAxis("Vertical"), Space.World);
        //     currentPlayer.transform.Translate(transform.forward * walkingSpeed * Time.deltaTime * Input.GetAxis("Vertical"), Space.World);

        //}
    }
}
