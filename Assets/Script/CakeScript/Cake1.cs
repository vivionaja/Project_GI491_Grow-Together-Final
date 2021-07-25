using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cake1 : MonoBehaviour
{
    public int HappyValue;
    public int CakePrice;
    public GameObject _Cake;
    public AudioSource buttonSFX;
    public AudioSource MoneySFX;
    public AudioSource WrongSFX;

    private void OnMouseOver()
    {
        _Cake.SetActive(true);
        if (Input.GetMouseButtonDown(0))
        {
            
            if (Player.HappyValue < Player.maxHappyValue)
            {
                
                if (Player.money >= CakePrice)
                {
                    MoneySFX.Play();
                    Player.HappyValue += HappyValue;
                    Player.money -= CakePrice;
                    Debug.Log(HappyValue);
                    if (Player.HappyValue > Player.maxHappyValue)
                    {
                        Player.HappyValue = 12;   
                    }
                }
                
            }
            else
            {
                WrongSFX.Play();
            }
        }
    }

    private void OnMouseEnter()
    {
        buttonSFX.Play();
    }
    private void OnMouseExit()
    {
        buttonSFX.Stop();
        _Cake.SetActive(false);
    }
}
