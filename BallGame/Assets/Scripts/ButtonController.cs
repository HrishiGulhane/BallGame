using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour {

    public AudioSource mySfx;
    public AudioClip hoverSfx;
    public AudioClip clickSfx;

    public void Hover()
    {
        mySfx.PlayOneShot(hoverSfx);
    }
    public void Click()
    {
        mySfx.PlayOneShot(clickSfx);
    }

}
