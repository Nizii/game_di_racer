using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{

    public void PressA(InputAction.CallbackContext value)
    {
        Debug.Log("Triggered");
        if (value.started)
        {
            Debug.Log("Triggered");
            SceneManager.LoadScene("Tutorial", LoadSceneMode.Single);
        }
    }
}
