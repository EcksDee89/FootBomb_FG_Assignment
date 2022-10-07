using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivePlayerCameraFollow : MonoBehaviour
{
    //public Transform targetObject;
    [SerializeField] private ActivePlayerManager manager;
    [SerializeField] private float speed;

    public Vector3 cameraOffset;

    public float smoothFactor = 0.5f;

    void Start()
    {
        //cameraOffset = transform.position - manager.GetCurrentPlayer().transform.position;    
    }

    void Update()
    {
        Vector3 targetPosition = manager.GetCurrentPlayer().transform.position + cameraOffset;

        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, step);
    }

    //private void LateUpdate()
    //{
    //    Vector3 newPosition = manager.GetCurrentPlayer().transform.position + cameraOffset;
    //    transform.position = newPosition;
    //}
}
