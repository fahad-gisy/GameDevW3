using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    // Start is called before the first frame update
    private Camera mainCam;
    void Start()
    {
        mainCam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        float targetX = transform.position.x;
        float targetY = transform.position.y;
        float targetZ = transform.position.y;
        
        mainCam.transform.position = new Vector3(targetX,targetY + 5 ,targetZ - 25);
    }
}
