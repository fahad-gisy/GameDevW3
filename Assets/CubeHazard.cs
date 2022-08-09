using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeHazard : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 startPoint;
    public Vector3 endPoint;
    public float hazardSpeed;

    public float knockBackForce = 5f;
    public float knockBackUp = 2f;
    // public FPSMovingWThree mainPlayerScript;
    void Start()
    {
        // mainPlayerScript = GetComponent<FPSMovingWThree>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = Vector3.Lerp(startPoint, endPoint, Mathf.PingPong(Time.time * hazardSpeed,1));
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent<FPSMovingWThree>(out var mainPlayerScript))
        {
            

        }
    }
}
