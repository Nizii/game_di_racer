using UnityEngine.InputSystem;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(CharacterController))]
public class Player2 : MonoBehaviour
{
    
    [SerializeField]
    private CharacterController controller;
    

    private Vector2 movementInput = Vector2.zero;
    private bool enter = false;

    //Alte Steuerung
    public Transform jetTransform;
    private float speed = 1f;

    //Countdown
    float currentTime = 0f;
    float startingTime = 3f;
    public TextMeshPro countdownText;

    private void Start()
    {
        currentTime = startingTime;
        controller = gameObject.GetComponent<CharacterController>();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        movementInput = context.ReadValue<Vector2>();
    }

    public void OnEnter(InputAction.CallbackContext context)
    {
        enter = context.ReadValue<bool>();
        enter = context.action.triggered;
    }

    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");

        if (currentTime <= 0)
        {
            Vector3 steeringInput = new Vector3(movementInput.x * 0.05f, 0, 0);
            Vector3 newForward = transform.rotation * steeringInput + transform.forward;
            
            transform.rotation = Quaternion.LookRotation(newForward);
            transform.position += transform.forward * speed;
            controller.Move(steeringInput * 3);
        }

        // A Button für Controller
        if (enter)
        {
            
        }

    }
}