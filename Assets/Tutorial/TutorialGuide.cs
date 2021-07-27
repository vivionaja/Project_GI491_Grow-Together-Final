using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TutorialGuide : MonoBehaviour
{
    DayDay day;
    
    public GameObject endTextTu;
    public GameObject TutorialText;
    public GameObject countText;
    public Text desGuide;
    public GameObject[] jokeButton;
    public GameObject guideClick;
    public static bool isStart ;
    public static bool isEvent ;
    public static bool isLogmom ;
    public static bool isQuest;
    public static bool isQuestBuy ;
    public static bool isQuestBuyCom;
    public static bool isQuestRub ;
    public static bool isQuestBrush ;
    public static bool isQuestAccept;
    public static bool isGoBakery;
    public static bool isGoMagic;
    public static bool isEndTu;
    bool isDoCount = false;
    bool isDosleep = false ;

    //ColiderBlock
    public GameObject[] BlockPath; 

    
    void Update()
    {
        if (isStart == true)
        {
            TutorialText.SetActive(true);
            desGuide.text = "Walk to the calendar, then press 'Spacebar'.";
        }
        if (isEvent == true)
        {
            desGuide.text = "Go talk to your mom, walk to her and press 'Spacebar'.";
            Destroy(BlockPath[0]);
        }
        if (isLogmom == true)
        {
            desGuide.text = "Click the 'Quest' button to accept the quest.";
        }
        if (isQuest == true)
        {
            desGuide.text = "Accept 'Brush your teeth'.";
        }
        if (isQuestAccept == true )
        {
            guideClick.SetActive(true);
            desGuide.text = "Click 'Check Quest' to look at the quest description.";
        }
        if (isQuestBrush == true)
        {
            guideClick.SetActive(false);
            desGuide.text = "Finish 'Brush your teeth' quest.";
            Destroy(BlockPath[1]);
        }
        if (isQuestRub == true)
        {
            jokeButton[1].SetActive(false);
            desGuide.text = "Accept and finish 'Mop the floor' quest.";
            Destroy(BlockPath[2]);
        }
        if (isQuestBuy == true)
        {
            jokeButton[0].SetActive(false);
            desGuide.text = "Accept and finish 'Shopping at the market' quest.";
            Destroy(BlockPath[3]);
        }
        if (isQuestBuyCom == true && isDoCount == false)
        {
            countText.SetActive(true);
            
            desGuide.text = "Go to the bakery to buy sweets to increase Happiness.";
            isDoCount = true;
        }
        if(isQuestBuyCom == true)
        {
            desGuide.text = "Go to the bakery to buy sweets to increase Happiness.";
            Destroy(BlockPath[4]);
        }
        if (isGoBakery == true)
        {
            desGuide.text = "When Happiness increases, go to the Magic shop to spin the wheel.";
            Destroy(BlockPath[5]);
        }
        if (isGoMagic == true)
        {
            desGuide.text = "Oh no! Time’s up! I have to go to bed, otherwise my Happiness will decrease.";
            if (isDosleep == false)
            {
                DayDay.TimeTutorial();
                isDosleep = true;
            }
        }
        if (isEndTu == true)
        {
            endTextTu.SetActive(true);
        }
    }

    public void QuitAlert()
    {
        countText.SetActive(false);
    }
    public void GotoGame()
    {
        SceneManager.LoadScene(1);
    }
}
