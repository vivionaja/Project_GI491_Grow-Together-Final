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

    
    void Update()
    {
        if (isStart == true)
        {
            TutorialText.SetActive(true);
            desGuide.text = "เดินไปที่ปะดิทิน แล้วกด 'Spacebar'";
        }
        if (isEvent == true)
        {
            desGuide.text = "ไปคุยกับแม่ เดินไปหาแม่แล้วกด 'Spacebar'";
        }
        if (isLogmom == true)
        {
            desGuide.text = "กดปุ่ม 'Quest' เพื่อรับรับเควส";
        }
        if (isQuest == true)
        {
            desGuide.text = "รับเควส 'Brush your teeth' ";
        }
        if (isQuestAccept == true )
        {
            guideClick.SetActive(true);
            desGuide.text = "กดปุ่ม 'Check Quest' เพื่อดูรายละเอียดเควส ";
        }
        if (isQuestBrush == true)
        {
            guideClick.SetActive(false);
            desGuide.text = "ทำเควส 'Brush your teeth' ให้สำเร็จ ";
        }
        if (isQuestRub == true)
        {
            jokeButton[1].SetActive(false);
            desGuide.text = "ไปรับเควส 'Mob The Floor' และทำให้สำเร็จ";
        }
        if (isQuestBuy == true)
        {
            jokeButton[0].SetActive(false);
            desGuide.text = "ไปรับเควส 'Shopping at the market' และทำให้สำเร็จ";
        }
        if (isQuestBuyCom == true && isDoCount == false)
        {
            countText.SetActive(true);
            
            desGuide.text = "ไปเบเกอรี่ เพื่อซื้อเค้กเพื่อให้ค่าความสุขเพิ่ม";
            isDoCount = true;
        }
        if(isQuestBuyCom == true)
        {
           
            desGuide.text = "ไปเบเกอรี่ เพื่อซื้อเค้กเพื่อให้ค่าความสุขเพิ่ม";
            
        }
        if (isGoBakery == true)
        {
            desGuide.text = "เมื่อค่าความสุข เพิ่มแล้ว ให้ไปร้าน magic shop เพื่อหมุนวงล้อ";
        }
        if (isGoMagic == true)
        {
            desGuide.text = "แย่แล้วเวลาจะหมดแล้ว ให้รีบกับไปเข้านอน ถ้าไม่ทันค่าความสุขจะลด";
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
