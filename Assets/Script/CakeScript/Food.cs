using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    public GameObject _Food;

    public AudioSource buttonSFX;

    private void OnMouseOver()
    {
        _Food.SetActive(true);
        if (Input.GetMouseButtonDown(0))
        {
            buttonSFX.Play();
        }
    }
    private void OnMouseExit()
    {
        _Food.SetActive(false);
    }
}
