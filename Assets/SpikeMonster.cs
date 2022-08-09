using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpikeMonster : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float speed = 3;
    [SerializeField] private float rotationSpeed = 1;
    [SerializeField] private Vector3 startPoint;
    [SerializeField] private Vector3 endPoint;
    // public FPSMovingWThree _fpsMovingWThree;
    public Image healthBar;
    public float healthAmount;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,rotationSpeed,0);
        transform.position = Vector3.Lerp(startPoint, endPoint, Mathf.PingPong(Time.time,1) * speed);
        healthBar.fillAmount = healthAmount;

    }

   
 

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent<FPSMovingWThree>(out var mainPlayerScript))
        {
            mainPlayerScript.health--;
            healthAmount -= 5.0f * Time.deltaTime;

        }
    }
}
