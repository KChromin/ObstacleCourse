using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    private Rigidbody objectRigidbody;

    [SerializeField]
    private float rotationSpeed;


    private void Awake()
    {
        objectRigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Rotate();
    }

    private void Rotate()
    {
        objectRigidbody.AddTorque(0, rotationSpeed - objectRigidbody.angularVelocity.y, 0, ForceMode.VelocityChange);
    }
}