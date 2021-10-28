
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
    private float WaterJetRotation_Y = 0f;
    public Transform waterJetTransform;

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
            WaterJetRotation_Y = waterJetTransform.localEulerAngles.y + 2f;

            if (WaterJetRotation_Y > 30f && WaterJetRotation_Y < 270f)
            {
                WaterJetRotation_Y = 30f;
            }

            Vector3 newRotation = new Vector3(0f, WaterJetRotation_Y, 0f);

            waterJetTransform.localEulerAngles = newRotation;
        }

        //right
        if (move.ReadValue<Vector2>().x < 0f)
        {
            WaterJetRotation_Y = waterJetTransform.localEulerAngles.y - 2f;

            if (WaterJetRotation_Y < 330f && WaterJetRotation_Y > 90f)
            {
                WaterJetRotation_Y = 330f;
            }

            Vector3 newRotation = new Vector3(0f, WaterJetRotation_Y, 0f);

            waterJetTransform.localEulerAngles = newRotation;
        }

        if (move.ReadValue<Vector2>().x == 0f)
        {
            Debug.Log("Zero " + move.ReadValue<Vector2>().x);
            rb.AddRelativeForce(Vector3.forward * 100);
        }
    }
   }