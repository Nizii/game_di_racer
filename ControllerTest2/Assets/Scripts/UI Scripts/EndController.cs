using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
public class EndController : MonoBehaviour
{
    public AudioSource clickSound;
    public AudioClip click;

    public void OnEnterButton(InputAction.CallbackContext value)
    {
        clickSound.PlayOneShot(click);
        SceneManager.LoadScene("Startmenu");
    }
}