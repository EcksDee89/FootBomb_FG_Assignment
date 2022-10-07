using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivePlayerCameraFollow : MonoBehaviour
{
    [SerializeField] private ActivePlayerManager manager;
    [SerializeField] private float speed;

    public Vector3 cameraOffset;

    public float smoothFactor = 0.5f;

    void Update()
    {
        Vector3 targetPosition = manager.GetCurrentPlayer().transform.position + cameraOffset;

        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, step);
    }
}
