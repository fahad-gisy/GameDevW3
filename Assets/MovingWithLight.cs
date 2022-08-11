using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingWithLight : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float speed = 5;
    public CharacterController characterController;
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float inputH = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float inputV = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        Vector3 movements = transform.right * inputH + transform.forward * inputV;
        characterController.Move(movements);
    }

    private void FixedUpdate()
    {
        

    }
}
