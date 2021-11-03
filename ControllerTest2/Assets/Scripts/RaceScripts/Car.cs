using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Car : MonoBehaviour
{

    private InputAction move;
    private ControllerInput controllerInput;
    private int physicUpdateCount;

    private bool isLeftTurnAllowed = true;
    private bool isRightTurnAllowed = true;

    private float steering;
    [SerializeField]
    private float turnAngle = 0.1f;

    [SerializeField]
    private trackCreator track;
    // Start is called before the first frame update
    void Start()
    {

    }

    private void Awake()
    {
        controllerInput = new ControllerInput();
    }
    private void OnEnable()
    {
        move = controllerInput.Racer.RacerMove;
        controllerInput.Racer.Enable();
    }

    private void OnDisable()
    {
        controllerInput.Racer.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (physicUpdateCount % 2 == 0)
        {
            if (physicUpdateCount > 20) //Head Start for Track
            {
                this.DriveCar();
            }
        }
           
        physicUpdateCount++;
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("the car hit: " + other.name);
        switch (other.name)
        {
            case "leftBorder":
                isLeftTurnAllowed = false;
                break;
            case "rightBorder":
                isRightTurnAllowed = false;
                break;
        }
        Debug.Log("hit at: " + other.gameObject.transform.forward);
        transform.rotation = Quaternion.LookRotation(other.gameObject.transform.forward, transform.up);
    }
    private void OnTriggerExit(Collider other)
    {
        isLeftTurnAllowed = isRightTurnAllowed = true;
    }

    public void OnMoveCar(InputAction.CallbackContext value)
    {
        steering = move.ReadValue<Vector2>().x * turnAngle;
    }
    private void DriveCar()
    {
        Vector3[] currentCarUp = track.getCurrentCarUp(transform.position);
        //float steering = move.ReadValue<Vector2>().x * 0.1f;
        if(!isLeftTurnAllowed && steering < 0 || !isRightTurnAllowed && steering > 0)
        {
            steering = 0;
        }
        Vector3 steeringInput = new Vector3(steering, 0, 0);
        Vector3 newForward = transform.rotation * steeringInput + transform.forward;

        Vector3 upDifferenceRotationAngle = Vector3.Cross(currentCarUp[0], newForward);
        float upDifferenceAngleSigned = Vector3.SignedAngle(transform.up, currentCarUp[0], upDifferenceRotationAngle);

        Vector3 newForwardRotated = Quaternion.AngleAxis(upDifferenceAngleSigned, upDifferenceRotationAngle) * newForward;
        transform.rotation = Quaternion.LookRotation(newForwardRotated, currentCarUp[0]);

        Plane plane = new Plane(currentCarUp[0], currentCarUp[1]); // ground plane
        Ray ray = new Ray(transform.position, -currentCarUp[0]);
        float distance; // the distance from the ray origin to the ray intersection of the plane
        if (plane.Raycast(ray, out distance))
        {
            transform.position = ray.GetPoint(distance-1f) + transform.forward * track.getSpeed(); // distance along the ray
            Debug.DrawRay(ray.origin, ray.direction * distance, Color.yellow);
        } else
        {
            Debug.Log("my Ray did not hit :(");
        }
    }
}
