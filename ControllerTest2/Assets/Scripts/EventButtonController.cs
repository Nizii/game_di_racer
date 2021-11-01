using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class HoverButton : MonoBehaviour
{
    public AudioSource hoverSound;
    public AudioClip hover;
    public AudioClip click;
    public AudioClip exit;

    public void HoverSound()
    {
        hoverSound.PlayOneShot(hover);
    }

    public void ClickSound()
    {
        hoverSound.PlayOneShot(click);        
    }

    public void ExitSound()
    {
        hoverSound.PlayOneShot(exit);
    }

}
