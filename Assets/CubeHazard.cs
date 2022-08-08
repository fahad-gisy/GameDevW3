using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeHazard : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 startPoint;
    public Vector3 endPoint;
    public float hazardSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = Vector3.Lerp(startPoint, endPoint, Mathf.PingPong(Time.time * hazardSpeed,1));
    }
}
