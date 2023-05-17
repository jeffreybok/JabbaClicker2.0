using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip buttonClickSound;

    private void Start()
    {

    }


    public void PlayGame()
    {
        //SceneManager.LoadScene("SampleScene");

        audioSource.PlayOneShot(buttonClickSound);

        SceneManager.LoadScene("GameScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}