
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    //input fields
    private PlayerOneInput playerOneInput;
    private InputAction move;
    private InputAction curve;

    //movement fields
    private Rigidbody rb;
    [SerializeField]
    private float movementForce = 20f;
    public float rotationSpeed = 200f;
    [SerializeField]
    private float maxSpeed = 100;
    private float currentSpeed = 0;
    private Vector3 forceDirection = Vector3.zero;
    //private Vector3 curveDirection = Vector3.zero;

    

    [SerializeField]
    private Camera playerCamera;
    private Animator animator;

    private void Awake()
    {
        rb = this.GetComponent<Rigidbody>();
        playerOneInput = new PlayerOneInput();
        animator = this.GetComponent<Animator>();
    }

    private void OnEnable()
    {
        //look = PlayerOneInput.PlayerOne.Look;
        move = playerOneInput.PlayerOne.Move;
        playerOneInput.PlayerOne.Enable();
    }

    private void OnDisable()
    {
        playerOneInput.PlayerOne.Disable();
    }

    private void FixedUpdate()
    {
        //Links/Rechts
        //forceDirection += move.ReadValue<Vector2>().x * GetCameraRight(playerCamera) * movementForce;

        
        if (currentSpeed < maxSpeed)
        {
            rb.AddRelativeForce(Vector3.forward * 50);
        }
        

        //Beschleunigen
        //forceDirection += move.ReadValue<Vector2>().y * GetCameraForward(playerCamera) * movementForce;

        //rb.AddForce(forceDirection, ForceMode.Impulse);
        //rb.AddTorque(forceDirection, ForceMode.Impulse);
        
        //forceDirection = Vector3.zero;
       // curveDirection = Vector3.zero;
       /*
        if (rb.velocity.y < 0f)
        {
            rb.velocity -= Vector3.down * Physics.gravity.y * Time.fixedDeltaTime;
        }

        Vector3 horizontalVelocity = rb.velocity;
        horizontalVelocity.y = 0;
        if (horizontalVelocity.sqrMagnitude > maxSpeed * maxSpeed)
        {
            rb.velocity = horizontalVelocity.normalized * maxSpeed + Vector3.up * rb.velocity.y;
        }
       */
    }

    private void Update()
    {
        //forceDirection += move.ReadValue<Vector2>().y * GetCameraRight(playerCamera) * movementForce;

        if (Input.GetAxis("Horizontal") > 0.2f)
        {
            //transform.localRotation = Quaternion.Euler(forceDirection);
            //transform.localRotation = Quaternion.Euler(new Vector3(0, forceDirection, 0));
            rb.AddTorque(Vector3.up * rotationSpeed);
        } 
        else if (Input.GetAxis("Horizontal") < -0.2f)
        {
            //transform.localRotation = Quaternion.Euler(new Vector3(0, -forceDirection, 0));
            //transform.localRotation = Quaternion.Euler(forceDirection);
            rb.AddTorque(-Vector3.up *rotationSpeed);
        } 
        else
        {
            //transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 0));
        }
        //rb.AddForce(forceDirection, ForceMode.Impulse);
        //forceDirection = Vector3.zero;
    }


    private Vector3 GetCameraForward(Camera playerCamera)
    {
        Vector3 forward = playerCamera.transform.forward;
        forward.y = 0;
        return forward.normalized;
    }

    private Vector3 GetCameraRight(Camera playerCamera)
    {
        Vector3 right = playerCamera.transform.right;
        right.y = 0;
        return right.normalized;
    }

}