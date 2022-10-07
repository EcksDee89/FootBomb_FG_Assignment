using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivePlayerCamera : MonoBehaviour
{
    [SerializeField] private ActivePlayerManager manager;
    [SerializeField] private Vector3 distanceFromThePlayer;
    [SerializeField] private float speed;
    /// <summary>
    /// //////////
    /// </summary>
    /// 

   

    //[SerializeField] private Camera characterCamera;
    //[SerializeField] private float speedH = 2.0f;
    //[SerializeField] private float speedV = 2.0f;
    //[SerializeField] private float pitchClamp = 90;

    

    //private float yaw = 0.0f;
    //private float pitch = 0.0f;


    void Update()
    {
        
        Vector3 targetPosition = manager.GetCurrentPlayer().transform.position + distanceFromThePlayer;

        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, step);

        
       

        

        //yaw += speedH * Input.GetAxis("Mouse X");
        //pitch -= speedV * Input.GetAxis("Mouse Y");
        //pitch = Mathf.Clamp(pitch, -pitchClamp, pitchClamp);

        //characterCamera.transform.localEulerAngles = new Vector3(pitch, 0.0f, 0.0f);
        //transform.eulerAngles = new Vector3(0.0f, yaw, 0.0f);
    }
}
