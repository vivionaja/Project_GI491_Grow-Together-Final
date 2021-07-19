using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DayDay : MonoBehaviour
{
    public Transform spawnpoint;
    public int day = 0;
    int maxHappy;
    public GameObject happyTownMap;
    public GameObject home;
    public GameObject player1;
    public Text dayTxt;
    public Player player;
    public GameObject scenesSleep;
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
    

    // Start is called before the first frame update
    void Start()
    {
        RandomQuest();
        takingAway = false;
        timerMin = 2;
        timerSec = 59;
        day = 1;
        dayTxt.text = "Day : " + day;
        timerDisplay.GetComponent<Text>().text = "0" + timerMin + ":" + timerSec;

    }

    void Update()
    {
        if (takingAway == false && timerSec >= 0 && sleep == false)
        {
            StartCoroutine(TimerTake());
        }
        UseGoSleep();
    }

    void TimerSet()
    {
        takingAway = false;
        timerMin = 2;
        timerSec = 59;
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
            if (player.lateSleep == true)
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
        dayTxt.text = "Day : " + day;
        player.currentQuest = 0;
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
        sleep = true;
        scenesSleep.SetActive(true);
        endScenesSleep.SetActive(false);
    }

    public void GoSleep()
    {
        sleep = true;
        player.lateSleep = false;
        player.lateLateSleep = false;
        scenesSleep.SetActive(true);
        endScenesSleep.SetActive(false);
    }
    public void NextScene()
    {
        endScenesSleep.SetActive(true);
    }
    public void endScene()
    {
        QuestGive.isEndseen = true;
        isRan = false;
        scenesSleep.SetActive(false);
        endScenesSleep.SetActive(false);
        NextDay();
        TimerSet();
        sleep = false;
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
}


