using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeMonster : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float speed = 3;
    [SerializeField] private float rotationSpeed = 1;
    [SerializeField] private Vector3 startPoint;
    [SerializeField] private Vector3 endPoint;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,rotationSpeed,0);
        transform.localPosition = Vector3.Lerp(startPoint, endPoint, Mathf.PingPong(Time.time,1) * speed);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent<FPSMovingWThree>(out var mainPlayerScript))
        {
            mainPlayerScript.health--;
        }
    }
}
