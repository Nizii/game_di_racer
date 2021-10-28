
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
    private float JetRotation_Y = 0f;
    public Transform jetTransform;

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
        /*
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
        */

        rb.velocity = Vector3.ClampMagnitude(rb.velocity, 300.0f);

        //left
        if (move.ReadValue<Vector2>().x > 0f)
        {
            Debug.Log("Left " + move.ReadValue<Vector2>().x);
            JetRotation_Y = jetTransform.localEulerAngles.y + 2f;

            if (JetRotation_Y > 30f && JetRotation_Y < 270f)
            {
                JetRotation_Y = 30f;
            }

            Vector3 newRotation = new Vector3(0f, JetRotation_Y, 0f);

            jetTransform.localEulerAngles = newRotation;
        }

        //right
        if (move.ReadValue<Vector2>().x < 0f)
        {
            JetRotation_Y = jetTransform.localEulerAngles.y - 2f;

            if (JetRotation_Y < 330f && JetRotation_Y > 90f)
            {
                JetRotation_Y = 330f;
            }

            Vector3 newRotation = new Vector3(0f, JetRotation_Y, 0f);

            jetTransform.localEulerAngles = newRotation;
        }

        if (move.ReadValue<Vector2>().x == 0f)
        {
            Debug.Log("Zero " + move.ReadValue<Vector2>().x);
            rb.AddRelativeForce(Vector3.forward * 100);
        }
    }
   }