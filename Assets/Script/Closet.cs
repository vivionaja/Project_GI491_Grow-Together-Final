using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Closet : MonoBehaviour
{
    public GameObject _ClosetCollection;
    bool CheckTrigger = false;
    public AudioSource _OpenClosetSFX;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && CheckTrigger == true)
        {
            _OpenClosetSFX.Play();
            _ClosetCollection.SetActive(true);
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

    public void CloseCloset()
    {
        _ClosetCollection.SetActive(false);
    }
}
