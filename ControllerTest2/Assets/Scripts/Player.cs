
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

    private void Update()
    {

        rb.AddForce(Vector3.forward * 20f);


        if (move.ReadValue<Vector2>().x > 0.1f)
        {
            rb.AddTorque(Vector3.up * 10f, ForceMode.Impulse);
            rb.AddForce(Vector3.right * 10f, ForceMode.Impulse);
       
        } 
        else if (move.ReadValue<Vector2>().x < -0.1f)
        {
            rb.AddTorque(-Vector3.up * 10f, ForceMode.Impulse);
            rb.AddForce(Vector3.left * 10f, ForceMode.Impulse);
        } 
        else
        {

        }        
    }
}