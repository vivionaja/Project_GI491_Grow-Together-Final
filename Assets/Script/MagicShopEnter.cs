using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MagicShopEnter : MonoBehaviour
{
    public GameObject _MagicShop;
    public GameObject _HappyTownMap;
    public GameObject _CameraFollowPlayer;
    public GameObject _CameraMain;
    public GameObject _ExitMagicShop;
    public GameObject _Spin;
    public GameObject _MagicShop02;
    public GameObject _BGMMainMap;

    bool CheckTrigger = false;

    public AudioSource popupPlaceSFX;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && CheckTrigger == true)
        {
            Debug.Log("Push");
            _CameraFollowPlayer.SetActive(false);
            _CameraMain.SetActive(true);
            //_HappyTownMap.SetActive(false);
            _MagicShop.SetActive(true);
            _ExitMagicShop.SetActive(true);
            _Spin.SetActive(true);
            _BGMMainMap.SetActive(false);
            CheckTrigger = false;
            PlayerController2D.InShop = true;
        }
    }
    public void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player") && CheckTrigger == false)
        {
            _MagicShop02.SetActive(true);
            CheckTrigger = true;

            popupPlaceSFX.Play();
        }
    }
    public void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            _MagicShop02.SetActive(false);
            CheckTrigger = false;
        }
    }

    public void ExitMagicShop()
    {
        _CameraFollowPlayer.SetActive(true);
        _CameraMain.SetActive(false);
        //_HappyTownMap.SetActive(true);
        _MagicShop.SetActive(false);
        _ExitMagicShop.SetActive(false);
        _Spin.SetActive(false);
        _BGMMainMap.SetActive(true);
        PlayerController2D.InShop = false;
    }
}
