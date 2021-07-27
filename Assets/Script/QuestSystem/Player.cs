using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public GameObject _Unhappy;

    public AudioSource ShowerSFX;
    public AudioSource MoppingSFX;
    public AudioSource BrushTeethSFX;
    public AudioSource WaterThePlantsSFX;
    public AudioSource WashDishesSFX;
    public AudioSource SweepSFX;
    public AudioSource GetClothSFX;
    public AudioSource EatSFX;

    Animator anim;
    public bool isRub;
    public bool isSweep;
    public bool isBrush;
    public bool isPick;
    public bool isWater;
    
    public static int number;

    public static bool haveQ1 =false;
    public static bool haveQ2 = false;
    public static bool cheakQ2 = false;
    public static bool haveQ4 =false;
    public static bool haveQ5 = false;
    public static bool cheakQ5 = false;
    public static bool haveQ6 =false;
    public static bool cheakQ7 = false;
    public static bool cheakQ8 = false;
    public static bool cheakQ9 = false;
    public static bool isMushroom = false;
    public static bool thisMushroom = false;
    public static bool isSalmon = false;
    public static bool thisSalmon = false;

    CheakAray cheak;
    public GameObject popUpWash;   
    public GameObject[] popUpWater;
    public GameObject[] PlantsColider;
    public GameObject popUpBrush;    
    public GameObject popUpBath;   
    public GameObject[] popUpBuy;    
    public GameObject popUpEat;  
    public GameObject[] popUpRub;
    public GameObject[] popUpPick;
    public GameObject[] popUpSweep;
    public static bool Checkquest1 = false;
    public static bool Checkquest2 = false;
    public static bool Checkquest3 = false;
    public static bool Checkquest4 = false;
    public static bool Checkquest5 = false;
    public static bool Checkquest6 = false;
    public static bool Checkquest7 = false;
    public static bool Checkquest8 = false;
    public static bool Checkquest9 = false;
    public static bool haveQuest;
    public static bool isWork;
   
    public bool lateSleep;
    public bool lateLateSleep;
    public bool lateLateLateSleep;
    public int maxQuest = 3;
    public int currentQuest;

    public static int money = 0;
    public string moneytxt;
    public Text txtmoney;
    public Text TextHappy;
    public static int HappyValue = 6;
    public static int maxHappyValue = 12;

    public Quest quest;

    private void Start()
    {
        anim = GetComponent<Animator>();
        haveQuest = false;
    }

    public void Update()
    {
        TextHappy.text = "" + HappyValue;
        txtmoney.text = "" + money;
        Quest1Button();
        anim.SetBool("isRub", isRub);
        anim.SetBool("isSweep", isSweep);
        anim.SetBool("isPick", isPick);
        anim.SetBool("isBrush", isBrush);
        anim.SetBool("isWater", isWater);
        if(HappyValue == 0)
        {
            _Unhappy.SetActive(true);
        }
        else
        {
            _Unhappy.SetActive(false);
        }
        if (HappyValue >12)
        {
            HappyValue = 12;
        }
    }
    public static void CheckHappy()
    {
        if (HappyValue > maxHappyValue)
        {
            HappyValue = 12;
        }
    }

    public void NextDay()
    {
        currentQuest = 0;
    }

    public void Quest1Button()//ปุ่มกดให้เควสทำงาน
    {
        if (Input.GetKeyDown(KeyCode.Space) && Checkquest1 == true)
        {
            quest.CheckButton = true;
            if (haveQ1 == true)
            {
                ItemAnim.isWash = true;
                WashDishesSFX.Play();
                isWork = true;
            }
            QuestWash();
            StartCoroutine(Deley());
        }
        if (Input.GetKeyDown(KeyCode.Space) && Checkquest2 == true)
        {
            quest.CheckButton = true;
            if (haveQ2 == true)
            {
                WaterThePlantsSFX.Play();
                isWater = true;
                isWork = true;
            }
            QuestWater();
            StartCoroutine(Deley());
        }
        if (Input.GetKeyDown(KeyCode.Space) && Checkquest3 == true)
        {
            quest.CheckButton = true;
            BrushTeethSFX.Play();
            isBrush = true;
            isWork = true;
            QuestBrush();
            StartCoroutine(Deley());
        }
        if (Input.GetKeyDown(KeyCode.Space) && Checkquest4 == true)
        {
            quest.CheckButton = true;
            if (haveQ4 == true)
            {
                ItemAnim.isBath = true;
                ShowerSFX.Play();
                isWork = true;
            }
            QuestBath();
            StartCoroutine(Deley());
        }
        
        if (Input.GetKeyDown(KeyCode.Space) && Checkquest6 == true)
        {
            quest.CheckButton = true;
            if (haveQ6 == true)
            {
                EatSFX.Play();
                ItemAnim.isEat = true;
                isWork = true;
            }
            QuestEat();
            StartCoroutine(Deley());
        }
        if (Input.GetKeyDown(KeyCode.Space) && Checkquest7 == true)
        {
            quest.CheckButton = true;
            MoppingSFX.Play();
            isRub = true;
            isWork = true;
            QuestRub();
            StartCoroutine(Deley());
        }
        if (Input.GetKeyDown(KeyCode.Space) && Checkquest8 == true)
        {
            quest.CheckButton = true;
            GetClothSFX.Play();
            isPick = true;
            isWork = true;
            QuestPick();
            StartCoroutine(Deley());
        }
        if (Input.GetKeyDown(KeyCode.Space) && Checkquest9 == true)
        {
            quest.CheckButton = true;
            SweepSFX.Play();
            isSweep = true;
            isWork = true;
            QuestSweep();
            StartCoroutine(Deley());
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Quest1"))
        {
            Checkquest1 = true;
            quest.CheckButton = true;
            
        }
        else if (other.CompareTag("Quest2") || other.CompareTag("Quest2.2"))
        {
            Checkquest2 = true;
            quest.CheckButton = true;
        }
        else if (other.CompareTag("Quest3"))
        {
            Checkquest3 = true;
            quest.CheckButton = true;
        }
        else if (other.CompareTag("Quest4"))
        {
            Checkquest4 = true;
            quest.CheckButton = true;
        }
        else if (other.CompareTag("Quest5") || other.CompareTag("Quest5.2"))
        {
            Checkquest5 = true;
            quest.CheckButton = true;
        }
        else if (other.CompareTag("Quest6"))
        {
            Checkquest6 = true;
            quest.CheckButton = true;
        }
        else if (other.CompareTag("Quest7") || other.CompareTag("Quest7.2"))
        {
            Checkquest7 = true;
            quest.CheckButton = true;
        }
        else if (other.CompareTag("Quest8") || other.CompareTag("Quest8.2"))
        {
            Checkquest8 = true;
            quest.CheckButton = true;
        }
        else if (other.CompareTag("Quest9") || other.CompareTag("Quest9.2") || other.CompareTag("Quest9.3"))
        {
            Checkquest9 = true;
            quest.CheckButton = true;
        }

    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Quest1"))
        {
            Checkquest1 = false;
            quest.CheckButton = false;
        }
        else if (other.CompareTag("Quest2") || other.CompareTag("Quest2.2"))
        {
            Checkquest2 = false;
            quest.CheckButton = false;
        }
        else if (other.CompareTag("Quest3"))
        {
            Checkquest3 = false;
            quest.CheckButton = false;
        }
        else if (other.CompareTag("Quest4"))
        {
            Checkquest4 = false;
            quest.CheckButton = false;
        }
        else if (other.CompareTag("Quest5") || other.CompareTag("Quest5.2"))
        {
            Checkquest5 = false;
            quest.CheckButton = false;
        }
        else if (other.CompareTag("Quest6"))
        {
            Checkquest6 = false;
            quest.CheckButton = false;
        }
        else if (other.CompareTag("Quest7") || other.CompareTag("Quest7.2"))
        {
            Checkquest7 = false;
            quest.CheckButton = false;
        }
        else if (other.CompareTag("Quest8") || other.CompareTag("Quest8.2"))
        {
            Checkquest8 = false;
            quest.CheckButton = false;
        }
        else if (other.CompareTag("Quest9") || other.CompareTag("Quest9.2") || other.CompareTag("Quest9.3"))
        {
            Checkquest9 = false;
            quest.CheckButton = false;
        }
    }

    //quest 
    public void QuestWash()
    {        
        if (quest.isActive)
        {
            quest.goal.DishWash();           
            if (quest.goal.IsReached())
            {
                if (DayDay.day % 5 == 0)
                {
                    money += (quest.money * 2);
                }
                else
                {
                    money += quest.money;
                }
                quest.Complete();
            }
        }
    }
    public void QuestWater()
    {
        if (quest.isActive)
        {
            quest.goal.Water();
            if (cheakQ2 == true && number == 1)
            {
                popUpWater[0].SetActive(false);
                PlantsColider[0].SetActive(false);
            }
            else if (cheakQ2 == true && number == 2)
            {
                popUpWater[1].SetActive(false);
                PlantsColider[1].SetActive(false);
            }
            if (quest.goal.IsReached())
            {
                if (DayDay.day % 5 == 0)
                {
                    money += (quest.money * 2);
                }
                else
                {
                    money += quest.money;
                }
                quest.Complete();
                txtmoney.text = "Money " + money;
            }
        }
    }

    public void QuestBrush()
    {
        if (quest.isActive)
        {
            quest.goal.Brush();
            if (quest.goal.IsReached())
            {
                if (DayDay.day % 5 == 0)
                {
                    money += (quest.money * 2);
                }
                else
                {
                    money += quest.money;
                }
                quest.Complete();
                txtmoney.text = "Money " + money;
            }
        }
    }
    public void QuestBath()
    {
        if (quest.isActive)
        {
            quest.goal.Bath();
            if (quest.goal.IsReached())
            {
                if (DayDay.day % 5 == 0)
                {
                    money += (quest.money * 2);
                }
                else
                {
                    money += quest.money;
                }
                quest.Complete();
                txtmoney.text = "Money " + money;
            }
        }
    }

    public void QuestBuy()
    {
        if (quest.isActive)
        {
            if(isMushroom == false && thisMushroom == true)
            {
                quest.goal.Buy();
                isMushroom = true;
                Debug.Log("ismush " + isMushroom);
            }
            else if(isSalmon == false && thisSalmon == true)
            {
                quest.goal.Buy();
                isSalmon = true;
            }

            if (quest.goal.IsReached())
            {
                if (DayDay.day % 5 == 0)
                {
                    money += (quest.money * 2);
                }
                else
                {
                    money += quest.money;
                }
                quest.Complete();
                txtmoney.text = "Money " + money;
            }
        }
    }
    public void QuestEat()
    {
        if (quest.isActive)
        {
            quest.goal.Eat();
            if (quest.goal.IsReached())
            {
                if (DayDay.day % 5 == 0)
                {
                    money += (quest.money * 2);
                }
                else
                {
                    money += quest.money;
                }
                quest.Complete();
                txtmoney.text = "Money " + money;
            }
        }
    }
    public void QuestRub()
    {
        if (quest.isActive)
        {
            quest.goal.Rub();
            if (cheakQ7 == true && number == 1)
            {     
                    popUpRub[0].SetActive(false);
            }
            else if (cheakQ7 == true && number == 2)
            {
                popUpRub[1].SetActive(false);
            }
            if (quest.goal.IsReached())
            {
                if (DayDay.day % 5 == 0)
                {
                    money += (quest.money * 2);
                }
                else
                {
                    money += quest.money;
                }
                quest.Complete();
                txtmoney.text = "Money " + money;
            }
        }
    }

    public void QuestPick()
    {
        if (quest.isActive)
        {
            quest.goal.Pick();
            if (cheakQ8 == true && number == 1)
            {
                popUpPick[0].SetActive(false);
                popUpPick[1].SetActive(true);
                
            }
            if (quest.goal.IsReached())
            {
                popUpPick[1].SetActive(false);
                if (DayDay.day % 5 == 0)
                {
                    money += (quest.money * 2);
                }
                else
                {
                    money += quest.money;
                }
                quest.Complete();
                txtmoney.text = "Money " + money;
            }
        }
    }
    public void QuestSweep()
    {
        if (quest.isActive)
        {
            quest.goal.Sweep();
            if (cheakQ9 == true && number == 1)
            {
                popUpSweep[0].SetActive(false);
            }
            else if (cheakQ9 == true && number == 2)
            {
                popUpSweep[1].SetActive(false);
            }
            else if (cheakQ9 == true && number == 3)
            {
                popUpSweep[2].SetActive(false);
            }
            if (quest.goal.IsReached())
            {
                if (DayDay.day % 5 == 0)
                {
                    money += (quest.money * 2);
                }
                else
                {
                    money += quest.money;
                }
                quest.Complete();
                txtmoney.text = "Money " + money;
            }
        }
    }
    IEnumerator Deley()
    {
        if (Checkquest1 == true)
        {
            yield return new WaitForSecondsRealtime(5);
            ItemAnim.isWash = false;
            isWork = false;
        }
        if (Checkquest4 == true)
        {
            yield return new WaitForSecondsRealtime(4);
            ItemAnim.isBath = false;
            isWork = false;
        }
        if (Checkquest6 == true)
        {
            yield return new WaitForSecondsRealtime(5);
            ItemAnim.isEat = false;
            isWork = false;
        }
        if (Checkquest3)
        {
            yield return new WaitForSecondsRealtime(4);
            isBrush = false;
            isWork = false;
        }
        else
        {
            yield return new WaitForSecondsRealtime(2);
            isRub = false;
            isSweep = false;
            isPick = false;
            isWater = false;
            isWork = false;
        }
        

    }
}
