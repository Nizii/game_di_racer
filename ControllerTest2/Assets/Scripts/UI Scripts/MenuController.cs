using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class MenuController : MonoBehaviour
{
    public GameObject Point;

    private int SelectedButton = 1;
    public Transform ButtonPosition1;
    public Transform ButtonPosition2;

    public AudioSource hoverSound;
    public AudioSource clickSound;
    public AudioClip click;
    public AudioClip clickHover;

    public void OnEnterButton(InputAction.CallbackContext value)
    {
        clickSound.PlayOneShot(click);
        if (SelectedButton == 1)
        {
            // When the button with the pointer is clicked, this piece of script is activated
            clickSound.PlayOneShot(click);
            SceneManager.LoadScene("Tutorial");
        }
        else if (SelectedButton == 2)
        {
            // When the button with the pointer is clicked, this piece of script is activated
            clickSound.PlayOneShot(click);
            Application.Quit();
        }
    }

    public void OnUpButton(InputAction.CallbackContext value)
    {
        hoverSound.PlayOneShot(clickHover);
        if (SelectedButton > 1)
            SelectedButton--;
        MoveThePointer();
    }

    public void OnDownButton(InputAction.CallbackContext value)
    {
        hoverSound.PlayOneShot(clickHover);
        if(SelectedButton < 2)
            SelectedButton++;
        MoveThePointer();
    }

    private void MoveThePointer()
    {
        // Moves the pointer
        if (SelectedButton == 1)
        {
            Point.transform.position = ButtonPosition1.position;
        }
        else if (SelectedButton == 2)
        {
            Point.transform.position = ButtonPosition2.position;
        }

    }

}