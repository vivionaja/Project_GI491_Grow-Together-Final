using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CaldenerEnter : MonoBehaviour
{
    public GameObject _Caldener;

    bool CheckTrigger = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && CheckTrigger == true)
        {
            _Caldener.SetActive(true);
        }
    }
    public void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player") && CheckTrigger == false)
        {
            CheckTrigger = true;
        }
    }
    public void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            CheckTrigger = false;
        }
    }

    public void CloseCaldener()
    {
        _Caldener.SetActive(false);
    }

}
