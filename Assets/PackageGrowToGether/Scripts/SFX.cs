using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFX : MonoBehaviour
{
    public AudioSource buttonSFX;

    public void ButtonSFX()
    {
        buttonSFX.Play();
    }
}
