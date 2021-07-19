using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cake1 : MonoBehaviour
{
    //public int maxHappyValue;
    public int HappyValue;
    public int CakePrice;
    public GameObject _Cake;
    public AudioSource buttonSFX;
    
    private void OnMouseOver()
    {
        _Cake.SetActive(true);
        if (Input.GetMouseButtonDown(0))
        {
            buttonSFX.Play();
            if (Player.HappyValue < Player.maxHappyValue)
            {
                
                if (Player.money >= CakePrice)
                {
                    Player.HappyValue += HappyValue;
                    Player.money -= CakePrice;
                    Debug.Log(HappyValue);
                    if (Player.HappyValue > Player.maxHappyValue)
                    {
                        Player.HappyValue = 12;
                        
                    }
                }
            }
        }
    }
    private void OnMouseExit()
    {
        _Cake.SetActive(false);
    }
}
