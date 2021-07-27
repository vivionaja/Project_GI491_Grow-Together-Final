using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CakeTu : MonoBehaviour
{
    public int HappyValue;
    public int CakePrice;
    public GameObject _Cake;
    public GameObject Bakery;
    public GameObject HappyTownMap;
    public GameObject CameraFollowPlayer;
    public GameObject CameraMain;
    public GameObject ExitBakery;
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
                    TutorialGuide.isGoBakery = true;
                    MoneySFX.Play();
                    Player.HappyValue += HappyValue;
                    Player.money -= CakePrice;
                    Debug.Log(HappyValue);
                    if (Player.HappyValue > Player.maxHappyValue)
                    {
                        Player.HappyValue = 12;
                    }
                    Bakery.SetActive(false);
                    HappyTownMap.SetActive(true);
                    CameraFollowPlayer.SetActive(true);
                    CameraMain.SetActive(false);
                    ExitBakery.SetActive(false);
                    PlayerController2D.InShop = false;
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
