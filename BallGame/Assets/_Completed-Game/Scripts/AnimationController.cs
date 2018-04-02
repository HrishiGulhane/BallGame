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

    public void MainMenu()
    {
        mainMenu.Play("menu");
    }
}
