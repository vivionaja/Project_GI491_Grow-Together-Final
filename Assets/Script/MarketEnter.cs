using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MarketEnter : MonoBehaviour
{
    public GameObject _Market;
    public GameObject _HappyTownMap;
    public GameObject _CameraFollowPlayer;
    public GameObject _CameraMain;
    public GameObject _ExitMarket;
    public GameObject _RightButton;
    public GameObject _LeftButton;
    public GameObject _Market01;
    public GameObject _Market02;
    public GameObject _MarketEnter02;


    bool CheckTrigger = false;

    public AudioSource popupPlaceSFX;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && CheckTrigger == true)
        {
            Debug.Log("Push");
            _CameraFollowPlayer.SetActive(false);
            _CameraMain.SetActive(true);
            _HappyTownMap.SetActive(false);
            _Market.SetActive(true);
            _RightButton.SetActive(true);
            _ExitMarket.SetActive(true);
            CheckTrigger = false;
            PlayerController2D.InShop = true;
        }
    }
    public void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player") && CheckTrigger == false)
        {
            _MarketEnter02.SetActive(true);
            CheckTrigger = true;

            popupPlaceSFX.Play();
        }
    }
    public void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            _MarketEnter02.SetActive(false);
            CheckTrigger = false;
        }
    }

    public void RightButton()
    {
        _Market01.SetActive(false);
        _Market02.SetActive(true);
        _LeftButton.SetActive(true);
        _RightButton.SetActive(false);
    }
    public void LeftButton()
    {
        _Market01.SetActive(true);
        _Market02.SetActive(false);
        _LeftButton.SetActive(false);
        _RightButton.SetActive(true);
    }

    public void ExitMarket()
    {
        _HappyTownMap.SetActive(true);
        _CameraFollowPlayer.SetActive(true);
        _CameraMain.SetActive(false);
        _Market.SetActive(false);
        _ExitMarket.SetActive(false);

        PlayerController2D.InShop = false;
    }
}
