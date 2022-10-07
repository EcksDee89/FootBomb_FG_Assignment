using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivePlayerInput : MonoBehaviour
{
    [SerializeField] private ActivePlayerManager manager;

    public Image powerFill;



    
    public float ballSpeed = 10f;
    public float maxPower;

    private void Start()
    {
        powerFill.fillAmount = 0;
    }

    void Update()
    {
        if (manager.PlayerCanPlay())
        {

            

            if (Input.GetKey(KeyCode.Space))
            {
                ballSpeed += Mathf.Min(10f * Time.deltaTime, maxPower);

                powerFill.fillAmount =(1f / (maxPower - 10f)) * (ballSpeed - 10f);
                if (ballSpeed >= maxPower)
                {
                    ActivePlayer currentPlayer = manager.GetCurrentPlayer();
                    currentPlayer.ShootBall(maxPower);
                    ballSpeed = 10f;
                    powerFill.fillAmount = 0f;
                }
            }

            if (Input.GetKeyUp(KeyCode.Space))
            {
                Debug.Log(string.Format("BallSpeed {0}", ballSpeed));
                ActivePlayer currentPlayer = manager.GetCurrentPlayer();
                currentPlayer.ShootBall(ballSpeed);
                ballSpeed = 10f;
                powerFill.fillAmount = 0f;
            }
        }
    }    
}


