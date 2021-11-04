using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;


public class TutorialController : MonoBehaviour
{
    public AudioSource clickSound;
    public AudioClip click;

    public void OnEnterButton(InputAction.CallbackContext value)
    {
        Debug.Log("Button pressed");
        clickSound.PlayOneShot(click);
        SceneManager.LoadScene("RaceWithTrack");
    }
}