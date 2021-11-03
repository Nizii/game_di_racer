using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerOneController : MonoBehaviour
{

    private PlayerOneInput playerOneInput;
    private Rigidbody rb;
    public float speed;
    public float turnSpeed;

    private void Awake()
    {
        playerOneInput = new PlayerOneInput();
    }

    private void OnEnable()
    {
        playerOneInput.Enable();   
    }

    private void OnDisable()
    {
        playerOneInput.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 move = playerOneInput.PlayerOne.Move.ReadValue<Vector2>();
        Debug.Log("Joystick -> "+move);
        /*
        if (playerOneInput.PlayerOne.Accelerate.triggered)
        {
            rb.AddRelativeForce(Vector3.forward * speed);
            Debug.Log("Accelerate");
        }

        if (playerOneInput.PlayerOne.Deccelerate.triggered)
        {
            rb.AddRelativeForce(-Vector3.forward * speed);
            Debug.Log("Deccelerate");
        }
        */
    }
}
