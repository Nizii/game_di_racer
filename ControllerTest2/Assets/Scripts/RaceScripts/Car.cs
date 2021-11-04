using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.SceneManagement;

public class Car : MonoBehaviour
{

    private int physicUpdateCount;

    private bool isLeftTurnAllowed = true;
    private bool isRightTurnAllowed = true;

    private float steering;
    [SerializeField]
    private float turnAngle = 0.1f;


    [SerializeField]
    private float borderBounceAngle = .03f;
    [SerializeField]
    private float borderBounceMove = .2f;

    [SerializeField]
    private trackCreator track;

    [SerializeField]
    private bool useStartCountdown = true;

    public int maxHealth = 100;
    private int currentHealth;
    public float gameTime = 60f;

    //UI
    public HealthBar healthbar;
    public HealthText healthText;
    public TimerText timerText;

    //Countdown
    float currentTime = 0f;
    float startingTime = 3f;
    public TextMeshPro countdownText;

    //GameOver Countdown
    float currentGameoverTime = 3f;

    //GameOver Sound
    //public AudioSource applauseSound;
    //public AudioClip applause;

    //Health
    public int damageEdge = 5;


    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
        currentHealth = maxHealth;
        healthbar.SetMaxHealt(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        //Test Healthbar
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(20);
        }
    }

    private void FixedUpdate()
    {
        //Countdown
        if (useStartCountdown)
        {
            currentTime -= 1 * Time.deltaTime;
            if (currentTime > 0)
            {
                countdownText.text = currentTime.ToString("0");
            }
        }
        else
        {
            currentTime = 0;
        }
        if (currentTime <= 0)
        {
            if (physicUpdateCount % 2 == 0)
            {
                if (physicUpdateCount > 20) //Head Start for Track
                {
                    this.DriveCar();
                }
            }
            physicUpdateCount++;

            //Game Timer
            gameTime -= 1 * Time.deltaTime;
            timerText.UpdateText(gameTime);
            if (gameTime <= 0f)
            {
                Debug.Log("Player won the Game");
                SceneManager.LoadScene("EndRacer");
            }
        }
    }
    /*
    private void GameOver()
    {
        currentGameoverTime -= 1 * Time.deltaTime;
        if (currentGameoverTime <= 0)
        {
            applauseSound.PlayOneShot(applause);
            SceneManager.LoadScene("End");
        }
    }
    */

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Track")
        {
            Vector3 turnIntoTrack = new Vector3(0f, 0f, 0f);
            switch (other.name)
            {
                case "leftBorder":
                    isLeftTurnAllowed = false;
                    transform.position += transform.right * borderBounceMove;
                    turnIntoTrack.x = -borderBounceAngle;
                    break;
                case "rightBorder":
                    isRightTurnAllowed = false;
                    transform.position += -transform.right * borderBounceMove;
                    turnIntoTrack.x = borderBounceAngle;
                    break;
            }
            TakeDamage(damageEdge);
            transform.rotation = Quaternion.LookRotation(other.gameObject.transform.forward + other.gameObject.transform.rotation * turnIntoTrack, transform.up);

        }
    }

    private void OnTriggerExit(Collider other)
    {
        isLeftTurnAllowed = isRightTurnAllowed = true;
    }

    public void OnMoveCar(InputAction.CallbackContext value)
    {
        steering = value.ReadValue<Vector2>().x * turnAngle;
    }
    private void DriveCar()
    {
        Vector3[] trackCenterNearestToCar = track.GetNearestCenterUp(transform.position);
        //float steering = move.ReadValue<Vector2>().x * 0.1f;
        if (!isLeftTurnAllowed && steering < 0 || !isRightTurnAllowed && steering > 0)
        {
            steering = 0;
        }
        Vector3 steeringInput = new Vector3(steering, 0, 0);
        Vector3 newForward = transform.rotation * steeringInput + transform.forward;

        Vector3 upDifferenceRotationAngle = Vector3.Cross(trackCenterNearestToCar[1], newForward);
        float upDifferenceAngleSigned = Vector3.SignedAngle(transform.up, trackCenterNearestToCar[1], upDifferenceRotationAngle);

        Vector3 newForwardRotated = Quaternion.AngleAxis(upDifferenceAngleSigned, upDifferenceRotationAngle) * newForward;
        transform.rotation = Quaternion.LookRotation(newForwardRotated, trackCenterNearestToCar[1]);

        Plane plane = new Plane(trackCenterNearestToCar[1], trackCenterNearestToCar[0]); // ground plane
        Ray ray = new Ray(transform.position, -trackCenterNearestToCar[1]);
        float distance; // the distance from the ray origin to the ray intersection of the plane
        if (plane.Raycast(ray, out distance))
        {
            transform.position = ray.GetPoint(distance - 1f) + transform.forward * track.GetSpeed(); // distance along the ray
            Debug.DrawRay(ray.origin, ray.direction * distance, Color.yellow);
        }
        else
        {
            Debug.Log("the Car must have lost the Track because my Ray did not hit :(");
        }
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthbar.SetHealth(currentHealth);
        healthText.UpdateText(currentHealth);
        Debug.Log("Nicht Tot " + currentHealth);
        if (currentHealth <= 0)
        {
            Debug.Log("Tot");
            SceneManager.LoadScene("EndTracker");
        }
    }
    public int getHealth()
    {
        return currentHealth;
    }
}
