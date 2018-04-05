using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public AudioSource menuAudioSource;
    public AudioClip menuBackground;

    private void Start()
    {
        menuAudioSource.PlayOneShot(menuBackground,0.25f);
    }

    public void PlayGame()
    {
        Invoke("SceneBoss", 0.4f);
       
    }
     
    public void SceneBoss()
    {
        SceneManager.LoadScene("Game");
    }

    public void QuitGame()
    {
        Application.Quit();
    }


}
