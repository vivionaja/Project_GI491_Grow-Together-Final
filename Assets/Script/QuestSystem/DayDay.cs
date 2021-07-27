using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DayDay : MonoBehaviour
{
    public GameObject[] SpecialDeal;
    public GameObject buttonWakeUp;
    public Text desEvent;
    public Text countText;

    public GameObject popUpHelp;
    public Transform spawnpoint;
    public static int day = 0;
    int maxHappy;
    public GameObject happyTownMap;
    public GameObject home;
    public GameObject MagicShop;
    public GameObject SpinWindowItem;
    public GameObject _Money5Bath;
    public GameObject _Money10Bath;
    public GameObject _Food;
    public GameObject _Money50Bath;
    public GameObject _Clothing;
    public GameObject _SpacialClothing;
    public GameObject SpinButton;
    public GameObject Market;
    public GameObject Bakery;

    public GameObject _GoToBedLate;
    public GameObject _GoToBedLate02;
    public GameObject _SleepOnTime;

    public GameObject player1;
    public Text dayTxt;
    public Player player;
    public GameObject endScenesSleep;

    public GameObject timerDisplay;
    public int timerMin;
    public int timerSec;
    public bool takingAway = true;
    public static bool sleep = false;

    bool Checkbed = false;

    public GameObject[] LootQuest;

    int randomNumber;

    public static bool isRan = false;

    public AudioSource sleepSFX;
    public AudioSource wakeUpSFX;
    public AudioSource sleeplateSFX;

    public GameObject _CameraFollowPlayer;
    public GameObject BGMHome;

    public GameObject _Tutorial;

 

    // Start is called before the first frame update
    void Start()
    {
        RandomQuest();
        takingAway = false;
        timerMin = 0;
        timerSec = -1;
        day = 0;
        dayTxt.text = "Day : " + day;
        timerDisplay.GetComponent<Text>().text = "0" + timerMin + ":" + timerSec;
        if (day % 5 == 0)
        {
            desEvent.text = "Money reward from quest will be doubled.";
        }

    }

    void Update()
    {
        if (takingAway == false && timerSec >= 0 && sleep == false)
        {
            StartCoroutine(TimerTake());
        }
        UseGoSleep();
    }
    public void TimeTutorial()
    {
        timerSec = 5;
    }
    public void TimeStart ()
    {
        day = 1;
        timerMin = 3;
        timerSec = 00;
        dayTxt.text = "Day : " + day;
        
        if (day % 7 == 0)
        {
            LootSystem.SpinPrice = 15;
            desEvent.text = "Price for spinning the wheel at the magic shop will be changed to $15.";
        }
        else if (day % 11 == 0)
        {
            LootSystem.SpinPrice = 10;
            desEvent.text = "Price for spinning the wheel at the magic shop will be changed to $10.";
        }
        else
        {
            desEvent.text = "";
        }
        if (day % 5 == 0)
        {
            desEvent.text = "Money reward from quest will be doubled.";
        }
        isRan = false;
        RandomQuest();
    }

    void TimerSet()
    {
        takingAway = false;
        timerMin = 3;
        timerSec = 00;
        dayTxt.text = "Day : " + day;
        timerDisplay.GetComponent<Text>().text = "0" + timerMin + ":" + timerSec;
    }
    IEnumerator TimerTake()
    {
        takingAway = true;
        if (timerMin > 0 && timerSec == 0)
        {
            timerDisplay.GetComponent<Text>().text = "0" + timerMin + ":0" + timerSec;
            
            timerMin -= 1;
            timerSec = 60;
        }
        else if (timerMin == 0 && timerSec == 0)
        {
            timerDisplay.GetComponent<Text>().text = "0" + timerMin + ":0" + timerSec;
            if (player.lateLateSleep == true)
            {
                player.lateLateLateSleep = true;
            }
            else if (player.lateSleep == true)
            {
                player.lateLateSleep = true;
               
            }
            player.lateSleep = true; 
            lateSleep();
        }

        yield return new WaitForSeconds(1);
        timerSec -= 1;
        Debug.Log("nt");
        if (timerMin < 10 && timerSec < 10)
        {
            timerDisplay.GetComponent<Text>().text = "0" + timerMin + ":0" + timerSec;
        }
        else if(timerMin < 10 )
        {
            timerDisplay.GetComponent<Text>().text = "0" + timerMin + ":" + timerSec;
        }
        
        takingAway = false;
    }

    public void NextDay()
    {
        day += 1;
        if (day % 7 == 0)
        {
            LootSystem.SpinPrice = 15;
            desEvent.text = "Price for spinning the wheel at the magic shop will be changed to $15.";
            SpecialDeal[0].SetActive(true);
        }
        else if (day % 11 == 0)
        {
            LootSystem.SpinPrice = 10;
            desEvent.text = "Price for spinning the wheel at the magic shop will be changed to $10.";
            SpecialDeal[1].SetActive(true);
        }
        else
        {
            LootSystem.SpinPrice = 20;
            desEvent.text = "";
            SpecialDeal[0].SetActive(false);
            SpecialDeal[1].SetActive(false);
        }
        if (day % 5 == 0)
        {
            desEvent.text = "Money reward from quest will be doubled.";
        }
       
        dayTxt.text = "Day : " + day;
        player.currentQuest = 0;
        countText.text = player.currentQuest + "/3";
        popUpHelp.SetActive(true);
        player1.transform.position = spawnpoint.transform.position;
        happyTownMap.SetActive(false);
        home.SetActive(true);
        RandomQuest();

        
        if (player.lateLateSleep == true && player.lateSleep == true)
        {
            Player.HappyValue = 2;
        }
        else if (player.lateSleep == true)
        {
           
            Player.HappyValue = 4;
        }
        else
        {
            
            Player.HappyValue = 6;
        }
        buttonWakeUp.SetActive(false);

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Checkbed = true;
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Checkbed = false;
        }
    }

    public void UseGoSleep()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Checkbed == true)
        {
            GoSleep();
        }
    }

    public void lateSleep()
    {
        sleeplateSFX.Play();
        BGMHome.SetActive(false);
        happyTownMap.SetActive(false);
        MagicShop.SetActive(false);
        SpinWindowItem.SetActive(false);
        _Money5Bath.SetActive(false);
        _Money10Bath.SetActive(false);
        _Money50Bath.SetActive(false);
        _SpacialClothing.SetActive(false);
        _Food.SetActive(false);
        _Clothing.SetActive(false);
        SpinButton.SetActive(false);
        Bakery.SetActive(false);
        Market.SetActive(false);
        _Tutorial.SetActive(false);
        sleep = true;
        endScenesSleep.SetActive(true);
        _CameraFollowPlayer.SetActive(true);
        _GoToBedLate02.SetActive(false);
        _GoToBedLate.SetActive(true);
        if (player.lateLateLateSleep == true)
        {
            _GoToBedLate.SetActive(false);
            _GoToBedLate02.SetActive(true);
        }

        PlayerController2D.InShop = true;
        StartCoroutine(deleyButtonWake());
    }

    public void GoSleep()
    {
        BGMHome.SetActive(false);
        sleepSFX.Play();
        sleep = true;
        player.lateSleep = false;
        player.lateLateSleep = false;
        endScenesSleep.SetActive(true);
        _SleepOnTime.SetActive(true);
        PlayerController2D.InShop = true;
        StartCoroutine(deleyButtonWake());
    }
   
    public void endScene()
    {
        TutorialGuide.isEndTu = true;
        QuestGive.isEndseen = true;
        isRan = false;
        endScenesSleep.SetActive(false);
        NextDay();
        TimerSet();
        sleep = false;
        sleepSFX.Stop();
        sleeplateSFX.Stop();
        wakeUpSFX.Play();
        BGMHome.SetActive(true);
        _GoToBedLate.SetActive(false);
        _GoToBedLate02.SetActive(false);
        _SleepOnTime.SetActive(false);
        _Tutorial.SetActive(true);
        PlayerController2D.InShop = false;
    }

    public void RandomQuest()
    {
        LootQuest[0].SetActive(false);
        LootQuest[1].SetActive(false);
        LootQuest[2].SetActive(false);
        LootQuest[3].SetActive(false);
        LootQuest[4].SetActive(false);
        LootQuest[5].SetActive(false);
        LootQuest[6].SetActive(false);
        LootQuest[7].SetActive(false);
        LootQuest[8].SetActive(false);

        if (isRan == false)
        {
            randomNumber = Random.Range(1, 10);

            Debug.Log(randomNumber);
            switch (randomNumber)
            {
                case 1:
                    LootQuest[0].SetActive(true);
                    break;

                case 2:
                    LootQuest[1].SetActive(true);
                    break;

                case 3:
                    LootQuest[2].SetActive(true);
                    break;

                case 4:
                    LootQuest[3].SetActive(true);
                    break;

                case 5:
                    LootQuest[4].SetActive(true);
                    break;

                case 6:
                    LootQuest[5].SetActive(true);
                    break;

                case 7:
                    LootQuest[6].SetActive(true);
                    break;

                case 8:
                    LootQuest[7].SetActive(true);
                    break;

                case 9:
                    LootQuest[8].SetActive(true);
                    break;

            }
            isRan = true;
        }

    }

    IEnumerator deleyButtonWake()
    {
        yield return new WaitForSeconds(2.0f);
        buttonWakeUp.SetActive(true);
    }
}


