using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimationController : MonoBehaviour {

    public Animator optionsMenu;
    public Animator mainMenu;

    public void playAnimation()
    {
        optionsMenu.Play("options");
    }
    public void playAnimationReverse()
    {

        optionsMenu.SetTrigger("rev");
    }

    public void MainMenu()
    {
        mainMenu.SetTrigger("rev");
    }

    public void MainMenuRev()
    {
        
        mainMenu.Play("menu");
    }
}
