using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AchievementPopUpInBook : MonoBehaviour
{
    public GameObject _PopUpAchievementInBook;
    public GameObject _CloseButton;

    public void OpenPopUpInBook()
    {

         Debug.Log("OpenPopUp");
        _PopUpAchievementInBook.SetActive(true);
        _CloseButton.SetActive(true);

    }
    public void ClosePopUpInBook()
    {

        Debug.Log("Close");
        _PopUpAchievementInBook.SetActive(false);
        _CloseButton.SetActive(false);

    }

}
