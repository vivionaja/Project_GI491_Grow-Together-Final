using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestGive : MonoBehaviour
{
    public bool TalkMom;
    public AudioSource _MomCloth;
    public AudioSource _MomWashDish;
    public AudioSource _MomPlant;
    public AudioSource _MomSweep;
    public AudioSource _MomMopping;
    public AudioSource _MomMarket;
    public AudioSource unlockAchieveSFX;
    public AudioSource _QuestFin;

    public Quest quest1;
    public GameObject popUpWash;
    public Quest quest2;
    public GameObject[] popUpWater;
    public Quest quest3;
    public GameObject popUpBrush;
    public Quest quest4;
    public GameObject popUpBath;
    public Quest quest5;
    public GameObject[] popUpBuy;
    public Quest quest6;
    public GameObject popUpEat;
    public Quest quest7;
    public GameObject[] popUpRub;
    public Quest quest8;
    public GameObject[] popUpPick;
    public Quest quest9;
    public GameObject[] popUpSweep;
    public GameObject popUpHelp;

    public Player player;

    public GameObject questWindowtxt;
    public GameObject descritWindowtxt;
    
    public GameObject questWindow;
    public GameObject logWindow;
    public Text titleText;
    public Text descritText;
    public Text minusHappyValue;
    public GameObject[] buttonAccept;
    public GameObject infoQuest;
    public Text questTitle;
    public Text questDes;
    public Text questMoney;
    public GameObject[] Textbutton;
    public static bool isEndseen;

    //Achievements
    public GameObject popUpAchievements;
    int CountQuest;
    int maxCountQuest = 100;
    //Mopping
    public GameObject popUpMoppingAchievementsCopper;
    public GameObject popUpMoppingAchievementsSilver;
    public GameObject popUpMoppingAchievementsGold;
    public GameObject MoppingAchievementsCollecCopper;
    public GameObject MoppingAchievementsCollecSilver;
    public GameObject MoppingAchievementsCollecGold;
    bool MoppingAchievementsCompleteCopper;
    bool MoppingAchievementsCompleteSilver;
    bool MoppingAchievementsCompleteGold;
    //Market
    public GameObject popUpMarketAchievementsCopper;
    public GameObject popUpMarketAchievementsSilver;
    public GameObject popUpMarketAchievementsGold;
    public GameObject MarketAchievementsCollecCopper;
    public GameObject MarketAchievementsCollecSilver;
    public GameObject MarketAchievementsCollecGold;
    bool MarketAchievementsCompleteCopper;
    bool MarketAchievementsCompleteSilver;
    bool MarketAchievementsCompleteGold;
    //PickUpCloth
    public GameObject popUpPickUpClothAchievementsCopper;
    public GameObject popUpPickUpClothAchievementsSilver;
    public GameObject popUpPickUpClothAchievementsGold;
    public GameObject PickUpClothAchievementsCollecCopper;
    public GameObject PickUpClothAchievementsCollecSilver;
    public GameObject PickUpClothAchievementsCollecGold;
    bool PickUpClothAchievementsCompleteCopper;
    bool PickUpClothAchievementsCompleteSilver;
    bool PickUpClothAchievementsCompleteGold;
    //WaterPlants
    public GameObject popUpWaterPlantsAchievementsCopper;
    public GameObject popUpWaterPlantsAchievementsSilver;
    public GameObject popUpWaterPlantsAchievementsGold;
    public GameObject WaterPlantsAchievementsCollecCopper;
    public GameObject WaterPlantsAchievementsCollecSilver;
    public GameObject WaterPlantsAchievementsCollecGold;
    bool WaterPlantsAchievementsCompleteCopper;
    bool WaterPlantsAchievementsCompleteSilver;
    bool WaterPlantsAchievementsCompleteGold;

    public void Start()
    {
        popUpHelp.SetActive(true);
    }

    public void Update()
    {
        ResetQuest();
        if (TalkMom && Input.GetKeyDown(KeyCode.Space))
        {
            OpenLogQuest();
        }
        if (player.currentQuest == player.maxQuest)
        {
            popUpHelp.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            TalkMom = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            TalkMom = false;
        }
    }

    public void OpenLogQuest()
    {
        logWindow.SetActive(true);   
    }

    public void CloseLogMom()
    {
        logWindow.SetActive(false);
    }

    public void OpenWindowQuest()
    {
        if (Player.haveQuest == false && player.currentQuest < player.maxQuest) 
        {
            questWindow.SetActive(true);
            logWindow.SetActive(false);
        } 
    }

    public void CloseWindowQuest()
    {
        questWindow.SetActive(false);
        logWindow.SetActive(false);
    }

    public void CancelQuest()
    {
        questWindow.SetActive(false);
        logWindow.SetActive(false);
        infoQuest.SetActive(false);
        buttonAccept[0].SetActive(false);
        buttonAccept[1].SetActive(false);
        buttonAccept[2].SetActive(false);
        buttonAccept[3].SetActive(false);
        buttonAccept[4].SetActive(false);
        buttonAccept[5].SetActive(false);
        buttonAccept[6].SetActive(false);
        buttonAccept[7].SetActive(false);
        buttonAccept[8].SetActive(false);
    }

    public void GiveQuest1()
    {
        if (Player.haveQuest == false && Player.HappyValue >= 1)
        {
            _MomWashDish.Play();
            questWindow.SetActive(false);
            questTitle.text = quest1.title;
            questDes.text = quest1.descrit;
            minusHappyValue.text = ""+ quest1.happyValue;
            questMoney.text = "" + quest1.money;
            buttonAccept[0].SetActive(true);
            infoQuest.SetActive(true);
        }
    }

    public void AcceptQuest1()
    {
        quest1.goal.currentAmount = 0;
        buttonAccept[0].SetActive(false);
        popUpWash.SetActive(true);
        questWindowtxt.SetActive(true);
        titleText.text = quest1.title;
        descritText.text = quest1.descrit;
        quest1.isActive = true;
        player.quest = quest1;
        Player.haveQuest = true;
        Player.haveQ1 = true;
        logWindow.SetActive(false);
        questWindow.SetActive(false);
        infoQuest.SetActive(false);
        popUpHelp.SetActive(false);
        Player.HappyValue += quest1.happyValue;
        Player.CheckHappy();
    }

    public void GiveQuest2()
    {
        if (Player.haveQuest == false && Player.HappyValue >= 1)
        {
            _MomPlant.Play();
            questWindow.SetActive(false);
            questTitle.text = quest2.title;
            questDes.text = quest2.descrit;
            minusHappyValue.text = "" + quest2.happyValue;
            questMoney.text = "" + quest2.money;
            buttonAccept[1].SetActive(true);
            infoQuest.SetActive(true);
        }
    }

    public void AcceptQuest2()
    {
        quest2.goal.currentAmount = 0;
        buttonAccept[1].SetActive(false);
        popUpWater[0].SetActive(true);
        popUpWater[1].SetActive(true);
        questWindowtxt.SetActive(true);
        titleText.text = quest2.title;
        descritText.text = quest2.descrit;
        quest2.isActive = true;
        player.quest = quest2;
        Player.haveQuest = true;
        Player.haveQ2 = true;
        logWindow.SetActive(false);
        questWindow.SetActive(false);
        infoQuest.SetActive(false);
        popUpHelp.SetActive(false);
        Player.HappyValue += quest2.happyValue;
        Player.CheckHappy();
    }

    public void GiveQuest3()
    {
        if (Player.haveQuest == false && Player.HappyValue >= 0)
        {
            questWindow.SetActive(false);
            questTitle.text = quest3.title;
            questDes.text = quest3.descrit;
            minusHappyValue.text = "" + quest3.happyValue;
            questMoney.text = "" + quest3.money;
            buttonAccept[2].SetActive(true);
            infoQuest.SetActive(true);
        }
    }

    public void AcceptQuest3()
    {
        quest3.goal.currentAmount = 0;
        buttonAccept[2].SetActive(false);
        popUpBrush.SetActive(true);
        questWindowtxt.SetActive(true);
        titleText.text = quest3.title;
        descritText.text = quest3.descrit;
        quest3.isActive = true;
        player.quest = quest3;
        Player.haveQuest = true;
        logWindow.SetActive(false);
        questWindow.SetActive(false);
        infoQuest.SetActive(false);
        popUpHelp.SetActive(false);
        Player.HappyValue += quest3.happyValue;
        Player.CheckHappy();
    }

    public void GiveQuest4()
    {
        if (Player.haveQuest == false && Player.HappyValue >= 0)
        {
            questWindow.SetActive(false);
            questTitle.text = quest4.title;
            questDes.text = quest4.descrit;
            minusHappyValue.text = "" + quest4.happyValue;
            questMoney.text = "" + quest4.money;
            buttonAccept[3].SetActive(true);
            infoQuest.SetActive(true);
        }
    }

    public void AcceptQuest4()
    {
        quest4.goal.currentAmount = 0;
        buttonAccept[3].SetActive(false);
        Player.haveQ4 = true;
        popUpBath.SetActive(true);
        questWindowtxt.SetActive(true);
        titleText.text = quest4.title;
        descritText.text = quest4.descrit;
        quest4.isActive = true;
        player.quest = quest4;
        Player.haveQuest = true;
        logWindow.SetActive(false);
        questWindow.SetActive(false);
        infoQuest.SetActive(false);
        popUpHelp.SetActive(false);
        Player.HappyValue += quest4.happyValue;
        Player.CheckHappy();
    }

    public void GiveQuest5()
    {
        if (Player.haveQuest == false && Player.HappyValue > 0)
        {
            _MomMarket.Play();
            questWindow.SetActive(false);
            questTitle.text = quest5.title;
            questDes.text = quest5.descrit;
            minusHappyValue.text = "" + quest5.happyValue;
            questMoney.text = "" + quest5.money;
            buttonAccept[4].SetActive(true);
            infoQuest.SetActive(true);
        }
    }

    public void AcceptQuest5()
    {
        quest5.goal.currentAmount = 0;
        Player.haveQ5 = true;
        buttonAccept[4].SetActive(false);
        //popUpBuy[].SetActive(true);
        questWindowtxt.SetActive(true);
        titleText.text = quest5.title;
        descritText.text = quest5.descrit;
        quest5.isActive = true;
        player.quest = quest5;
        Player.haveQuest = true;
        logWindow.SetActive(false);
        questWindow.SetActive(false);
        infoQuest.SetActive(false);
        popUpHelp.SetActive(false);
        Player.HappyValue += quest5.happyValue;
        Player.CheckHappy();
    }

    public void GiveQuest6()
    {
        if (Player.haveQuest == false && Player.HappyValue >= 0)
        {
            questWindow.SetActive(false);
            questTitle.text = quest6.title;
            questDes.text = quest6.descrit;
            minusHappyValue.text = "" + quest6.happyValue;
            questMoney.text = "" + quest6.money;
            buttonAccept[5].SetActive(true);
            infoQuest.SetActive(true);
        }
    }

    public void AcceptQuest6()
    {
        quest6.goal.currentAmount = 0;
        buttonAccept[5].SetActive(false);
        Player.haveQ6 = true;
        popUpEat.SetActive(true);
        questWindowtxt.SetActive(true);
        titleText.text = quest6.title;
        descritText.text = quest6.descrit;
        quest6.isActive = true;
        player.quest = quest6;
        Player.haveQuest = true;
        logWindow.SetActive(false);
        questWindow.SetActive(false);
        infoQuest.SetActive(false);
        popUpHelp.SetActive(false);
        Player.HappyValue += quest6.happyValue;
        Player.CheckHappy();
    }

    public void GiveQuest7()
    {
        if (Player.haveQuest == false && Player.HappyValue >= 2)
        {
            _MomMopping.Play();
            questWindow.SetActive(false);
            questTitle.text = quest7.title;
            questDes.text = quest7.descrit;
            minusHappyValue.text = "" + quest7.happyValue;
            questMoney.text = ""+ quest7.money;
            buttonAccept[6].SetActive(true);
            infoQuest.SetActive(true);
        }
    }

    public void AcceptQuest7()
    {
        quest7.goal.currentAmount = 0;
        buttonAccept[6].SetActive(false);
        popUpRub[0].SetActive(true);
        popUpRub[1].SetActive(true);
        questWindowtxt.SetActive(true);
        titleText.text = quest7.title;
        descritText.text = quest7.descrit;
        quest7.isActive = true;
        player.quest = quest7;
        Player.haveQuest = true;
        logWindow.SetActive(false);
        questWindow.SetActive(false);
        infoQuest.SetActive(false);
        popUpHelp.SetActive(false);
        Player.HappyValue += quest7.happyValue;
        Player.CheckHappy();
    }

    public void GiveQuest8()
    {
        if (Player.haveQuest == false && Player.HappyValue >= 2)
        {
            _MomCloth.Play();
            questWindow.SetActive(false);
            questTitle.text = quest8.title;
            questDes.text = quest8.descrit;
            minusHappyValue.text = "" + quest8.happyValue;
            questMoney.text = "" + quest8.money;
            buttonAccept[7].SetActive(true);
            infoQuest.SetActive(true);
        }
    }
    public void AcceptQuest8()
    {
        quest8.goal.currentAmount = 0;
        buttonAccept[7].SetActive(false);
        popUpPick[0].SetActive(true);
        questWindowtxt.SetActive(true);
        titleText.text = quest8.title;
        descritText.text = quest8.descrit;
        quest8.isActive = true;
        player.quest = quest8;
        Player.haveQuest = true;
        logWindow.SetActive(false);
        questWindow.SetActive(false);
        infoQuest.SetActive(false);
        popUpHelp.SetActive(false);
        Player.HappyValue += quest8.happyValue;
        Player.CheckHappy();
    }

    public void GiveQuest9()
    {
        if (Player.haveQuest == false && Player.HappyValue >= 2)
        {
            _MomSweep.Play();
            questWindow.SetActive(false);
            questTitle.text = quest9.title;
            questDes.text = quest9.descrit;
            minusHappyValue.text = "" + quest9.happyValue;
            questMoney.text = "" + quest9.money;
            buttonAccept[8].SetActive(true);
            infoQuest.SetActive(true);
        }
    }
    public void AcceptQuest9()
    {
        quest9.goal.currentAmount = 0;
        buttonAccept[8].SetActive(false);
        popUpSweep[0].SetActive(true);
        popUpSweep[1].SetActive(true);
        popUpSweep[2].SetActive(true);
        questWindowtxt.SetActive(true);
        titleText.text = quest9.title;
        descritText.text = quest9.descrit;
        quest9.isActive = true;
        player.quest = quest9;
        Player.haveQuest = true;
        logWindow.SetActive(false);
        questWindow.SetActive(false);
        infoQuest.SetActive(false);
        popUpHelp.SetActive(false);
        Player.HappyValue += quest9.happyValue;
        Player.CheckHappy();
    }

    public void QuestComplete()
    {
        if (Player.haveQuest == true)
        {
            if (player.quest.isActive == false)
            {
                questWindowtxt.SetActive(false);
                descritWindowtxt.SetActive(false);
                _QuestFin.Play();
                player.currentQuest += 1;
                Player.haveQuest = false;
                popUpHelp.SetActive(true);
                if (quest1.isFinish == true)
                {  
                    Player.haveQ1 = false;
                    Textbutton[0].SetActive(false);
                    Textbutton[1].SetActive(false);
                    Textbutton[2].SetActive(false);
                    popUpWash.SetActive(false);
                }
                else if (quest2.isFinish == true)
                {
                    Player.haveQ2 = false;
                    Textbutton[3].SetActive(false);
                    Textbutton[4].SetActive(false);
                    Textbutton[5].SetActive(false);
                    Textbutton[6].SetActive(false);

                    if (CountQuest < maxCountQuest)
                    {
                        CountQuest += 1;
                        if (CountQuest == 10 && WaterPlantsAchievementsCompleteCopper == false)
                        {
                            unlockAchieveSFX.Play();
                            Debug.Log("Copper");
                            Player.money += 100;
                            popUpAchievements.SetActive(true);
                            popUpWaterPlantsAchievementsCopper.SetActive(true);
                            WaterPlantsAchievementsCollecCopper.SetActive(true);
                            WaterPlantsAchievementsCompleteCopper = true;
                            StartCoroutine(ExitpopUpAchievements());
                        }
                        if (CountQuest == 50 && WaterPlantsAchievementsCompleteSilver == false)
                        {
                            unlockAchieveSFX.Play();
                            Debug.Log("Silver");
                            Player.money += 200;
                            popUpAchievements.SetActive(true);
                            popUpWaterPlantsAchievementsSilver.SetActive(true);
                            WaterPlantsAchievementsCollecCopper.SetActive(false);
                            WaterPlantsAchievementsCollecSilver.SetActive(true);
                            WaterPlantsAchievementsCompleteSilver = true;
                            StartCoroutine(ExitpopUpAchievements());
                        }
                        if (CountQuest == 100 && WaterPlantsAchievementsCompleteGold == false)
                        {
                            unlockAchieveSFX.Play();
                            Debug.Log("Gold");
                            Player.money += 300;
                            popUpAchievements.SetActive(true);
                            popUpWaterPlantsAchievementsGold.SetActive(true);
                            WaterPlantsAchievementsCollecSilver.SetActive(false);
                            WaterPlantsAchievementsCollecGold.SetActive(true);
                            WaterPlantsAchievementsCompleteGold = true;
                            StartCoroutine(ExitpopUpAchievements());
                        }
                    }
                }
                else if (quest3.isFinish == true)
                {
                    Textbutton[7].SetActive(false);
                    Textbutton[8].SetActive(false);
                    Textbutton[9].SetActive(false);
                    Textbutton[10].SetActive(false);
                    popUpBrush.SetActive(false);
                }
                else if (quest4.isFinish == true)
                {
                    Player.haveQ4 = false;
                    Textbutton[11].SetActive(false);
                    Textbutton[12].SetActive(false);
                    Textbutton[13].SetActive(false);
                    popUpBath.SetActive(false);
                }
                else if (quest5.isFinish == true)
                {
                    Player.haveQ5 = false;
                    Player.isMushroom = false;
                    Player.isSalmon = false;
                    Textbutton[14].SetActive(false);
                    Textbutton[15].SetActive(false);
                    Textbutton[16].SetActive(false);
                    Textbutton[17].SetActive(false);
                    Textbutton[18].SetActive(false);

                    if (CountQuest < maxCountQuest)
                    {
                        CountQuest += 1;
                        if (CountQuest == 10 && MarketAchievementsCompleteCopper == false)
                        {
                            unlockAchieveSFX.Play();
                            Debug.Log("Copper");
                            Player.money += 100;
                            popUpAchievements.SetActive(true);
                            popUpMarketAchievementsCopper.SetActive(true);
                            MarketAchievementsCollecCopper.SetActive(true);
                            MarketAchievementsCompleteCopper = true;
                            StartCoroutine(ExitpopUpAchievements());
                        }
                        if (CountQuest == 50 && MarketAchievementsCompleteSilver == false)
                        {
                            unlockAchieveSFX.Play();
                            Debug.Log("Silver");
                            Player.money += 200;
                            popUpAchievements.SetActive(true);
                            popUpMarketAchievementsSilver.SetActive(true);
                            MarketAchievementsCollecCopper.SetActive(false);
                            MarketAchievementsCollecSilver.SetActive(true);
                            MarketAchievementsCompleteSilver = true;
                            StartCoroutine(ExitpopUpAchievements());
                        }
                        if (CountQuest == 100 && MarketAchievementsCompleteGold == false)
                        {
                            unlockAchieveSFX.Play();
                            Debug.Log("Gold");
                            Player.money += 300;
                            popUpAchievements.SetActive(true);
                            popUpMarketAchievementsGold.SetActive(true);
                            MarketAchievementsCollecSilver.SetActive(false);
                            MarketAchievementsCollecGold.SetActive(true);
                            MarketAchievementsCompleteGold = true;
                            StartCoroutine(ExitpopUpAchievements());
                        }
                    }
                }
                else if (quest6.isFinish == true)
                {
                    Player.haveQ6 = false;
                    Textbutton[19].SetActive(false);
                    Textbutton[20].SetActive(false);
                    Textbutton[21].SetActive(false);
                    Textbutton[22].SetActive(false);
                    popUpEat.SetActive(false);
                }
                else if (quest7.isFinish == true)
                {
                    Textbutton[23].SetActive(false);
                    Textbutton[24].SetActive(false);
                    Textbutton[25].SetActive(false);
                    Textbutton[26].SetActive(false);
                    Textbutton[27].SetActive(false);
                    Textbutton[28].SetActive(false);
                    
                    if (CountQuest < maxCountQuest)
                    {
                        CountQuest += 1;
                        if (CountQuest == 10 && MoppingAchievementsCompleteCopper == false)
                        {
                            unlockAchieveSFX.Play();
                            Debug.Log("Copper");
                            Player.money += 100;
                            popUpAchievements.SetActive(true);
                            popUpMoppingAchievementsCopper.SetActive(true);
                            MoppingAchievementsCollecCopper.SetActive(true);
                            MoppingAchievementsCompleteCopper = true;
                            StartCoroutine(ExitpopUpAchievements());
                        }
                        if (CountQuest == 50 && MoppingAchievementsCompleteSilver == false)
                        {
                            unlockAchieveSFX.Play();
                            Debug.Log("Silver");
                            Player.money += 200;
                            popUpAchievements.SetActive(true);
                            popUpMoppingAchievementsSilver.SetActive(true);
                            MoppingAchievementsCollecCopper.SetActive(false);
                            MoppingAchievementsCollecSilver.SetActive(true);
                            MoppingAchievementsCompleteSilver = true;
                            StartCoroutine(ExitpopUpAchievements());
                        }
                        if (CountQuest == 100 && MoppingAchievementsCompleteGold == false)
                        {
                            unlockAchieveSFX.Play();
                            Debug.Log("Gold");
                            Player.money += 300;
                            popUpAchievements.SetActive(true);
                            popUpMoppingAchievementsGold.SetActive(true);
                            MoppingAchievementsCollecSilver.SetActive(false);
                            MoppingAchievementsCollecGold.SetActive(true);
                            MoppingAchievementsCompleteGold = true;
                            StartCoroutine(ExitpopUpAchievements());
                        }
                    }
                }
                else if (quest8.isFinish == true)
                {
                    Textbutton[29].SetActive(false);
                    Textbutton[30].SetActive(false);
                    Textbutton[31].SetActive(false);
                    Textbutton[32].SetActive(false);

                    if (CountQuest < maxCountQuest)
                    {
                        CountQuest += 1;
                        if (CountQuest == 10 && PickUpClothAchievementsCompleteCopper == false)
                        {
                            unlockAchieveSFX.Play();
                            Debug.Log("Copper");
                            Player.money += 100;
                            popUpAchievements.SetActive(true);
                            popUpPickUpClothAchievementsCopper.SetActive(true);
                            PickUpClothAchievementsCollecCopper.SetActive(true);
                            PickUpClothAchievementsCompleteCopper = true;
                            StartCoroutine(ExitpopUpAchievements());
                        }
                        if (CountQuest == 50 && MoppingAchievementsCompleteSilver == false)
                        {
                            unlockAchieveSFX.Play();
                            Debug.Log("Silver");
                            Player.money += 200;
                            popUpAchievements.SetActive(true);
                            popUpPickUpClothAchievementsSilver.SetActive(true);
                            PickUpClothAchievementsCollecCopper.SetActive(false);
                            PickUpClothAchievementsCollecSilver.SetActive(true);
                            PickUpClothAchievementsCompleteSilver = true;
                            StartCoroutine(ExitpopUpAchievements());
                        }
                        if (CountQuest == 100 && MoppingAchievementsCompleteGold == false)
                        {
                            unlockAchieveSFX.Play();
                            Debug.Log("Gold");
                            Player.money += 300;
                            popUpAchievements.SetActive(true);
                            popUpPickUpClothAchievementsGold.SetActive(true);
                            PickUpClothAchievementsCollecSilver.SetActive(false);
                            PickUpClothAchievementsCollecGold.SetActive(true);
                            PickUpClothAchievementsCompleteGold = true;
                            StartCoroutine(ExitpopUpAchievements());
                        }
                    }
                }
                else if (quest9.isFinish == true)
                {
                    Textbutton[33].SetActive(false);
                    Textbutton[34].SetActive(false);
                    Textbutton[35].SetActive(false);
                }
                quest1.isFinish = false;
                quest2.isFinish = false;
                quest3.isFinish = false;
                quest4.isFinish = false;
                quest5.isFinish = false;
                quest6.isFinish = false;
                quest7.isFinish = false;
                quest8.isFinish = false;
                quest9.isFinish = false;
            }
        }
    }

    public void ResetQuest()
    {
        if (isEndseen == true)
        {
            Textbutton[0].SetActive(true);
            Textbutton[1].SetActive(true);
            Textbutton[2].SetActive(true);
            Textbutton[3].SetActive(true);
            Textbutton[4].SetActive(true);
            Textbutton[5].SetActive(true);
            Textbutton[6].SetActive(true);
            Textbutton[7].SetActive(true);
            Textbutton[8].SetActive(true);
            Textbutton[9].SetActive(true);
            Textbutton[10].SetActive(true);
            Textbutton[11].SetActive(true);
            Textbutton[12].SetActive(true);
            Textbutton[13].SetActive(true);
            Textbutton[14].SetActive(true);
            Textbutton[15].SetActive(true);
            Textbutton[16].SetActive(true);
            Textbutton[17].SetActive(true);
            Textbutton[18].SetActive(true);
            Textbutton[19].SetActive(true);
            Textbutton[20].SetActive(true);
            Textbutton[21].SetActive(true);
            Textbutton[22].SetActive(true);
            Textbutton[23].SetActive(true);
            Textbutton[24].SetActive(true);
            Textbutton[25].SetActive(true);
            Textbutton[26].SetActive(true);
            Textbutton[27].SetActive(true);
            Textbutton[28].SetActive(true);
            Textbutton[29].SetActive(true);
            Textbutton[30].SetActive(true);
            Textbutton[31].SetActive(true);
            Textbutton[32].SetActive(true);
            Textbutton[33].SetActive(true);
            Textbutton[34].SetActive(true);
            Textbutton[35].SetActive(true);

            isEndseen = false;
        }
    }
    private void FixedUpdate()
    {
        QuestComplete();
    }
    IEnumerator ExitpopUpAchievements()
    {
        yield return new WaitForSeconds(3.0f);
        popUpAchievements.SetActive(false);
        popUpMoppingAchievementsCopper.SetActive(false);
        popUpMoppingAchievementsSilver.SetActive(false);
        popUpMoppingAchievementsGold.SetActive(false);
        popUpAchievements.SetActive(false);
    }
}
