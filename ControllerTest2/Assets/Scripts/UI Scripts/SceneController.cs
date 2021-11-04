using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

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
        SceneManager.LoadScene("Tutorial", LoadSceneMode.Single);
    }

    // Quit Game
    public void ExitGame()
    {
        Application.Quit();
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
