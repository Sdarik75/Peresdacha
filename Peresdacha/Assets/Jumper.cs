using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    public float jumpForce;
    
    private void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            col.attachedRigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
