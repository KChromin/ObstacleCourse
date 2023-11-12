using System;
using UnityEngine;

public class Mover : MonoBehaviour
{
    private Rigidbody playerRigidbody;

    [SerializeField]
    private float moveSpeed;

    private void Awake()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Move();
    }

    private static Vector2 GetInput()
    {
        return new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }

    private void Move()
    {
        Vector2 input = GetInput();
        Vector3 input3D = new(input.x, 0, input.y);

        playerRigidbody.AddForce(input3D * moveSpeed, ForceMode.VelocityChange);
    }
}