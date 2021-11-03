using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class TutorialController : MonoBehaviour
{

    private PlayerOneInput playerOneInput;

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

    private void Update()
    {
        if (playerOneInput.Menu.Play.triggered)
        {
            SceneManager.LoadScene("Race");
        }
    }
}