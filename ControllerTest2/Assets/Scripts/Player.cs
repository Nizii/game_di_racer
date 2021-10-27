
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
        rb.velocity = Vector3.ClampMagnitude(rb.velocity, 60.0f);
        if (move.ReadValue<Vector2>().x > 0f)
        {
            rb.AddTorque(Vector3.up * 100f, ForceMode.Impulse);
            rb.AddRelativeForce(Vector3.right * 20f);
        }
        
        if (move.ReadValue<Vector2>().x < 0f)
        {
            rb.AddTorque(-Vector3.up * 100f, ForceMode.Impulse);
            rb.AddRelativeForce(Vector3.left * 20f);
        }
        
        if (move.ReadValue<Vector2>().x == 0f)
        {
            rb.AddRelativeForce(Vector3.forward * 20);
        }
    }
   }