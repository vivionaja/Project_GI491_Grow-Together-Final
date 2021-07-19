using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeEnter : MonoBehaviour
{
    public GameObject _HappyTownMap;
    public GameObject _HomeExit;
    public GameObject _Home02;
    //public GameObject _CameraHome;
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
            Debug.Log("InHome");
            _HappyTownMap.SetActive(false);
            //_CameraHome.SetActive(true);
            _HomeExit.SetActive(true);
            CheckTrigger = false;  
        }
    }
    public void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player") && CheckTrigger == false)
        {
            _Home02.SetActive(true);
            CheckTrigger = true;

            popupPlaceSFX.Play();
        }
    }
    public void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            _Home02.SetActive(false);
            CheckTrigger = false;
        }
    }
}
