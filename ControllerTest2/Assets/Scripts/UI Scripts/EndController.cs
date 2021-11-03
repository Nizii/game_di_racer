using UnityEngine;
using UnityEngine.SceneManagement;
public class EndController : MonoBehaviour
{
    private PlayerOneInput playerOneInput;
    public AudioSource clickSound;
    public AudioClip click;

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
            clickSound.PlayOneShot(click);
            SceneManager.LoadScene("Startmenu");
        }
    }
}