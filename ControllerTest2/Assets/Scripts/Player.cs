
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
    private float speed = 5f;

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

       // rb.velocity = Vector3.ClampMagnitude(rb.velocity, 400f);
        /*
        //left
        if (move.ReadValue<Vector2>().x > 0f)
        {
            JetRotation_Y = jetTransform.localEulerAngles.y + 1f;
            rb.AddRelativeForce(Vector3.forward * -20); 
            rb.AddRelativeForce(Vector3.right * 150);
            Vector3 newRotation = new Vector3(0f, JetRotation_Y, 0f);
            jetTransform.localEulerAngles = newRotation;
        }

        //right
        if (move.ReadValue<Vector2>().x < 0f)
        {
            Vector3 forward = Vector3.forward * -20;
            Vector3 left = Vector3.left * 150;
            JetRotation_Y = jetTransform.localEulerAngles.y - 1f;
            rb.AddRelativeForce(forward);
            rb.AddRelativeForce(left);
            Vector3 newRotation = new Vector3(0f, JetRotation_Y, 0f);
            jetTransform.localEulerAngles = newRotation;
        }

        if (move.ReadValue<Vector2>().x == 0f)
        {
            Debug.Log("Zero " + move.ReadValue<Vector2>().x);
            rb.AddRelativeForce(Vector3.forward * 100);
        }
        */

        Debug.Log(move.ReadValue<Vector2>().x);
        Vector3 steeringInput = new Vector3(move.ReadValue<Vector2>().x * 0.1f, 0, 0);
        Vector3 newForward = transform.rotation * steeringInput + transform.forward;
        transform.rotation = Quaternion.LookRotation(newForward);
        transform.position += transform.forward * speed;
        //rb.velocity = transform.forward * 400;


    }
}