using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LoadScene : MonoBehaviour
{
    public GameObject _Menu;
    public GameObject _StartButton;
    public GameObject _ExitButton;
    public GameObject _HowToPlay;
    public GameObject _HowToPlay02;

    public GameObject _Tutorial01;
    public GameObject _Tutorial02;
    public GameObject _Tutorial03;
    public GameObject _Tutorial04;
    public GameObject _Tutorial05;
    public GameObject _Tutorial06;
    public GameObject _Tutorial07;
    public GameObject _LeftButton02;
    public GameObject _LeftButton03;
    public GameObject _LeftButton04;
    public GameObject _LeftButton05;
    public GameObject _LeftButton06;
    public GameObject _LeftButton07;
    public GameObject _RightButton01;
    public GameObject _RightButton02;
    public GameObject _RightButton03;
    public GameObject _RightButton04;
    public GameObject _RightButton05;
    public GameObject _RightButton06;
    public GameObject _LetsGoButton;

    public GameObject _Player;
    public GameObject _Home;
    public GameObject _MoneyBar;
    public GameObject _TimeBar;
    public GameObject _Day;
    public GameObject _HappyBar;
    public GameObject _QuestsButton;
    public GameObject _CameraFollowPlayer;

    public GameObject _Bed;

    public GameObject _BGM;


    public void StartButton()
    {
        _Menu.SetActive(false);
        _StartButton.SetActive(false);
        _ExitButton.SetActive(false);
        _Player.SetActive(true);
        _Home.SetActive(true);
        _MoneyBar.SetActive(true);
        _TimeBar.SetActive(true);
        _Day.SetActive(true);
        _HappyBar.SetActive(true);
        _QuestsButton.SetActive(true);
        _HowToPlay.SetActive(true);
        _CameraFollowPlayer.SetActive(true);
        _Bed.SetActive(true);
        _BGM.SetActive(false);

    }
    public void HowToPlay()
    {
        _HowToPlay.SetActive(false);
        _HowToPlay02.SetActive(true);
        _Tutorial01.SetActive(true);
        _RightButton01.SetActive(true);
        _CameraFollowPlayer.SetActive(false);
        
    }

    public void HowToPlay02()
    {
        _Tutorial01.SetActive(false);
        _Tutorial02.SetActive(false);
        _Tutorial03.SetActive(false);
        _Tutorial04.SetActive(false);
        _Tutorial05.SetActive(false);
        _Tutorial06.SetActive(false);
        _Tutorial07.SetActive(false);
        _RightButton01.SetActive(false);
        _RightButton02.SetActive(false);
        _RightButton03.SetActive(false);
        _RightButton04.SetActive(false);
        _RightButton05.SetActive(false);
        _RightButton06.SetActive(false);
        _LeftButton02.SetActive(false);
        _LeftButton03.SetActive(false);
        _LeftButton04.SetActive(false);
        _LeftButton05.SetActive(false);
        _LeftButton06.SetActive(false);
        _LeftButton07.SetActive(false);
        _LetsGoButton.SetActive(false);
        _CameraFollowPlayer.SetActive(true);
        _HowToPlay.SetActive(true);
        _HowToPlay02.SetActive(false);
        
    }

    public void LeftButtonTutorial02()
    {
        _Tutorial02.SetActive(false);
        _LeftButton02.SetActive(false);
        _RightButton02.SetActive(false);
        _Tutorial01.SetActive(true);
        _RightButton01.SetActive(true);
      

    }
    public void LeftButtonTutorial03()
    {
        _Tutorial03.SetActive(false);
        _LeftButton03.SetActive(false);
        _RightButton03.SetActive(false);
        _Tutorial02.SetActive(true);
        _LeftButton02.SetActive(true);
        _RightButton02.SetActive(true);
        
    }
    public void LeftButtonTutorial04()
    {
        _Tutorial04.SetActive(false);
        _LeftButton04.SetActive(false);
        _RightButton04.SetActive(false);
        _Tutorial03.SetActive(true);
        _LeftButton03.SetActive(true);
        _RightButton03.SetActive(true);
       
    }
    public void LeftButtonTutorial05()
    {
        _Tutorial05.SetActive(false);
        _LeftButton05.SetActive(false);
        _LetsGoButton.SetActive(false);
        _Tutorial04.SetActive(true);
        _LeftButton04.SetActive(true);
        _RightButton04.SetActive(true);
      
    }

    public void RightButton01()
    {
        _Tutorial01.SetActive(false);
        _RightButton01.SetActive(false);
        _Tutorial02.SetActive(true);
        _LeftButton02.SetActive(true);
        _RightButton02.SetActive(true);
        
    }
    public void RightButton02()
    {
        _Tutorial02.SetActive(false);
        _LeftButton02.SetActive(false);
        _RightButton02.SetActive(false);
        _Tutorial03.SetActive(true);
        _LeftButton03.SetActive(true);
        _RightButton03.SetActive(true);
        

    }
    public void RightButton03()
    {
        _Tutorial03.SetActive(false);
        _LeftButton03.SetActive(false);
        _RightButton03.SetActive(false);
        _Tutorial04.SetActive(true);
        _LeftButton04.SetActive(true);
        _RightButton04.SetActive(true);
        
    }
    public void RightButton04()
    {
        _Tutorial04.SetActive(false);
        _LeftButton04.SetActive(false);
        _RightButton04.SetActive(false);
        _Tutorial05.SetActive(true);
        _LeftButton05.SetActive(true);
        _LetsGoButton.SetActive(true);
      
    }

    public void LetsGoButton()
    {
        _HowToPlay.SetActive(true);
        _HowToPlay02.SetActive(false);
        _Tutorial05.SetActive(false);
        _LeftButton05.SetActive(false);
        _LetsGoButton.SetActive(false);
        _CameraFollowPlayer.SetActive(true);
        

    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
