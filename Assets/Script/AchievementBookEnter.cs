using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AchievementBookEnter : MonoBehaviour
{
    public GameObject _AchievementBookCollection;
    public AudioSource _OpenAchievementBookSFX;
    bool CheckTrigger = false;



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && CheckTrigger == true)
        {
            _OpenAchievementBookSFX.Play();
            _AchievementBookCollection.SetActive(true);
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

    public void CloseAchievementBook()
    {
        _AchievementBookCollection.SetActive(false);
    }
}
