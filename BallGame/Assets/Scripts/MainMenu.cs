using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

 
    public void PlayGame()
    {
        Invoke("SceneBoss", 0.7f);
       
    }
     
    public void SceneBoss()
    {
        SceneManager.LoadScene("Game");
    }
   
    
}
