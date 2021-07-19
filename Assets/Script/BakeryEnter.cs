using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BakeryEnter : MonoBehaviour
{
    public GameObject _Bakery;
    public GameObject _HappyTownMap;
    public GameObject _CameraFollowPlayer;
    public GameObject _CameraMain;
    public GameObject _ExitBakery;
    public GameObject _Bakery02;

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
            _Bakery.SetActive(true);
            _ExitBakery.SetActive(true);
            CheckTrigger = false;
            PlayerController2D.InShop = true;
        }
    }

    public void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player") && CheckTrigger == false)
        {
            _Bakery02.SetActive(true);
            CheckTrigger = true;

            popupPlaceSFX.Play();
        }
    }
    public void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            _Bakery02.SetActive(false);
            CheckTrigger = false;
        }
    }

    public void ExitBakery()
    {
        _HappyTownMap.SetActive(true);
        _CameraFollowPlayer.SetActive(true);
        _CameraMain.SetActive(false);
        _Bakery.SetActive(false);
        _ExitBakery.SetActive(false);

        PlayerController2D.InShop = false;
    }
}
