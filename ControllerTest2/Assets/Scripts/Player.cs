
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private PlayerOneInput playerOneInput;
    private InputAction move;
    private Rigidbody rb;
    public float rotationSpeed = 20f;
    public float maxSpeed = 100;
    public float currentSpeed = 0;

    private void Awake()
    {
        rb = this.GetComponent<Rigidbody>();
        playerOneInput = new PlayerOneInput();
    }

    private void OnEnable()
    {
        move = playerOneInput.PlayerOne.Move;
        playerOneInput.PlayerOne.Enable();
    }

    private void OnDisable()
    {
        playerOneInput.PlayerOne.Disable();
    }

    private void FixedUpdate()
    {
        if (move.ReadValue<Vector2>().x > 0f)
        {
            rb.AddTorque(Vector3.up * 1f, ForceMode.Impulse);
            rb.AddRelativeForce(Vector3.right * 100);
            //rb.AddRelativeForce(Vector3.forward * 10);

        }
        
        if (move.ReadValue<Vector2>().x < 0f)
        {
            rb.AddTorque(-Vector3.up * 1f, ForceMode.Impulse);
            rb.AddRelativeForce(Vector3.left * 100);
            //aaawrb.AddRelativeForce(Vector3.forward * 10);
        }
        
        if (move.ReadValue<Vector2>().x == 0f)
        {
            rb.AddRelativeForce(Vector3.forward * 20);
        }
    }

    private void Update()
    {


    }
   }