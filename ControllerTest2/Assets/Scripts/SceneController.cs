using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{

    public GameObject startscreen;
    // Start is called before the first frame update
    void Start()
    {
        startscreen.SetActive(true);
    }

    public void DeactivateStartscreen()
    {
        startscreen.SetActive(false);
    }

    public void ChangeMyScene()
    {
        SceneManager.LoadScene("Race", LoadSceneMode.Single);
    }

    // Quit Game
    public void ExitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
