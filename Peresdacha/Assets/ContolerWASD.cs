using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContolerWASD : MonoBehaviour
{
    public Rigidbody rb;
    public Transform cam;
    public float speed;
    public float cameraMoveSmoothTime;

    private Vector3 cameraOffset;
    private Vector3 velocity;

    private void Start()
    {
        cameraOffset = cam.position - transform.position;
    }


    private void Update()
    {
        Vector3 direction = new Vector3();
        if (Input.GetKey(KeyCode.A))
        {
            direction += Vector3.left;
        }

        if (Input.GetKey(KeyCode.D))
        {
            direction += Vector3.right;
        }
        
        if (Input.GetKey(KeyCode.W))
        {
            direction += Vector3.forward;
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            direction += Vector3.back;
        }

        direction *= speed;
        rb.velocity = new Vector3(direction.x, rb.velocity.y, direction.z);
        

        Vector3 nextPosWithOffSet = transform.position + cameraOffset;
        cam.position = Vector3.SmoothDamp(cam.position, nextPosWithOffSet, ref velocity, cameraMoveSmoothTime);
    }
}
