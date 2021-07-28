using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LootSystem : MonoBehaviour
{
    public GameObject SpinButton02;

    public AudioSource getItemSFX;
    public AudioSource spinSFX;

    public GameObject _Roulette01;
    public GameObject _Roulette02;
    public GameObject _SpinItem_Window;
    public GameObject _Money5Bath;
    public GameObject _Money10Bath;
    public GameObject _Food;
    public GameObject _Money50Bath;
    public GameObject _Clothing;
    public GameObject _ClothingInBook;
    public static bool _itemToEndGame01 = false;
    public GameObject _SpacialClothing;
    public GameObject _SpacialClothingInBook;
    public static bool _itemToEndGame02 = false;

    float SpinNumber;

    public static int SpinPrice;
    public int Clothing;
    public int maxClothing = 2;
    public int SpacialClothing;
    public int maxSpacialClothing = 2;

    bool Check;

    bool CheckReceiveItemMoney10 = false;
    bool CheckReceiveItemFood = false;
    bool CheckReceiveItemMoney50 = false;
    bool CheckReceiveItemJoker = false;
    bool CheckReceiveItemClothing = false;
    bool CheckReceiveItemSpacialClothing = false;

    private void Start()
    {
        SpinPrice = 20;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Debug.Log("P");
            CheckReceiveItemClothing = true;
            _Clothing.SetActive(true);
            _ClothingInBook.SetActive(true);
            _itemToEndGame01 = true;
            CheckReceiveItemSpacialClothing = true;
            _SpacialClothing.SetActive(true);
            _SpacialClothingInBook.SetActive(true);
            _itemToEndGame02 = true;
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            Player.money += 1000;
        }
    }

    public void Spawnner()
    {
        SpinButton02.SetActive(true);
        if (Player.money >= SpinPrice)
        {
            
            Check = true;
            spinSFX.Play();
            _Roulette01.SetActive(false);
            _Roulette02.SetActive(true);
            Player.money -= SpinPrice;
            StartCoroutine(DelayOpenSpinWindow());

            if (Player.HappyValue <= 1)
            {
                SpinNumber = Random.Range(1.0f, 100.0f);
                Debug.Log(SpinNumber);
                if (SpinNumber >= 1 && SpinNumber <= 70)
                {
                    CheckReceiveItemJoker = true;
                    _Money5Bath.SetActive(true);

                }
                else if (SpinNumber > 70 && SpinNumber <= 83)
                {
                    CheckReceiveItemMoney10 = true;
                    _Money10Bath.SetActive(true);
                }
                else if (SpinNumber > 83 && SpinNumber <= 91)
                {
                    CheckReceiveItemFood = true;
                    _Food.SetActive(true);
                }
                else if (SpinNumber > 91 && SpinNumber <= 96)
                {
                    CheckReceiveItemMoney50 = true;
                    _Money50Bath.SetActive(true);
                }
                else if (SpinNumber > 96 && SpinNumber <= 99)
                {
                    CheckReceiveItemClothing = true;
                    _Clothing.SetActive(true);
                    _ClothingInBook.SetActive(true);
                 

                }
                else if (SpinNumber > 99 && SpinNumber <= 100)
                {
                    CheckReceiveItemSpacialClothing = true;
                    _SpacialClothing.SetActive(true);
                    _SpacialClothingInBook.SetActive(true);
                
                }
            }
            if (Player.HappyValue > 1 && Player.HappyValue <= 3)
            {
                SpinNumber = Random.Range(1.0f, 100.0f);
                Debug.Log(SpinNumber);
                if (SpinNumber >= 1 && SpinNumber <= 65)
                {
                    CheckReceiveItemJoker = true;
                    _Money5Bath.SetActive(true);

                }
                else if (SpinNumber > 65 && SpinNumber <= 79)
                {
                    CheckReceiveItemMoney10 = true;
                    _Money10Bath.SetActive(true);
                }
                else if (SpinNumber > 79 && SpinNumber <= 88)
                {
                    CheckReceiveItemFood = true;
                    _Food.SetActive(true);
                }
                else if (SpinNumber > 88 && SpinNumber <= 94)
                {
                    CheckReceiveItemMoney50 = true;
                    _Money50Bath.SetActive(true);
                }
                else if (SpinNumber > 94 && SpinNumber <= 98)
                {
                    CheckReceiveItemClothing = true;
                    _Clothing.SetActive(true);
                    _ClothingInBook.SetActive(true);
                  
                }
                else if (SpinNumber > 98 && SpinNumber <= 100)
                {
                    CheckReceiveItemSpacialClothing = true;
                    _SpacialClothing.SetActive(true);
                    _SpacialClothingInBook.SetActive(true);
                   
                }
            }
            if (Player.HappyValue > 3 && Player.HappyValue <= 5)
            {
                SpinNumber = Random.Range(1.0f, 100.0f);
                Debug.Log(SpinNumber);
                if (SpinNumber >= 1 && SpinNumber <= 60)
                {
                    CheckReceiveItemJoker = true;
                    _Money5Bath.SetActive(true);

                }
                else if (SpinNumber > 60 && SpinNumber <= 75)
                {
                    CheckReceiveItemMoney10 = true;
                    _Money10Bath.SetActive(true);
                }
                else if (SpinNumber > 75 && SpinNumber <= 85)
                {
                    CheckReceiveItemFood = true;
                    _Food.SetActive(true);
                }
                else if (SpinNumber > 85 && SpinNumber <= 92)
                {
                    CheckReceiveItemMoney50 = true;
                    _Money50Bath.SetActive(true);
                }
                else if (SpinNumber > 92 && SpinNumber <= 98)
                {
                    CheckReceiveItemClothing = true;
                    _Clothing.SetActive(true);
                    _ClothingInBook.SetActive(true);
                   
                }
                else if (SpinNumber > 98 && SpinNumber <= 100)
                {
                    CheckReceiveItemSpacialClothing = true;
                    _SpacialClothing.SetActive(true);
                    _SpacialClothingInBook.SetActive(true);
                   
                }
            }
            if (Player.HappyValue > 5 && Player.HappyValue <= 7)
            {
                SpinNumber = Random.Range(1.0f, 100.0f);
                Debug.Log(SpinNumber);
                if (SpinNumber >= 1 && SpinNumber <= 55)
                {
                    CheckReceiveItemJoker = true;
                    _Money5Bath.SetActive(true);

                }
                else if (SpinNumber > 55 && SpinNumber <= 71)
                {
                    CheckReceiveItemMoney10 = true;
                    _Money10Bath.SetActive(true);
                }
                else if (SpinNumber > 71 && SpinNumber <= 82)
                {
                    CheckReceiveItemFood = true;
                    _Food.SetActive(true);
                }
                else if (SpinNumber > 82 && SpinNumber <= 90)
                {
                    CheckReceiveItemMoney50 = true;
                    _Money50Bath.SetActive(true);
                }
                else if (SpinNumber > 90 && SpinNumber <= 97)
                {
                    CheckReceiveItemClothing = true;
                    _Clothing.SetActive(true);
                    _ClothingInBook.SetActive(true);
                    
                }
                else if (SpinNumber > 97 && SpinNumber <= 100)
                {
                    CheckReceiveItemSpacialClothing = true;
                    _SpacialClothing.SetActive(true);
                    _SpacialClothingInBook.SetActive(true);
                    
                }
            }
            if (Player.HappyValue > 7 && Player.HappyValue <= 9)
            {
                SpinNumber = Random.Range(1.0f, 100.0f);
                Debug.Log(SpinNumber);
                if (SpinNumber >= 1 && SpinNumber <= 50)
                {
                    CheckReceiveItemJoker = true;
                    _Money5Bath.SetActive(true);

                }
                else if (SpinNumber > 50 && SpinNumber <= 67)
                {
                    CheckReceiveItemMoney10 = true;
                    _Money10Bath.SetActive(true);
                }
                else if (SpinNumber > 67 && SpinNumber <= 80)
                {
                    CheckReceiveItemFood = true;
                    _Food.SetActive(true);
                }
                else if (SpinNumber > 80 && SpinNumber <= 90)
                {
                    CheckReceiveItemMoney50 = true;
                    _Money50Bath.SetActive(true);
                }
                else if (SpinNumber > 90 && SpinNumber <= 97)
                {
                    CheckReceiveItemClothing = true;
                    _Clothing.SetActive(true);
                    _ClothingInBook.SetActive(true);
                  
                }
                else if (SpinNumber > 97 && SpinNumber <= 100)
                {
                    CheckReceiveItemSpacialClothing = true;
                    _SpacialClothing.SetActive(true);
                    _SpacialClothingInBook.SetActive(true);
                   
                }
            }
            if (Player.HappyValue > 9 && Player.HappyValue <= 11)
            {
                SpinNumber = Random.Range(1.0f, 100.0f);
                Debug.Log(SpinNumber);
                if (SpinNumber >= 1 && SpinNumber <= 45)
                {
                    CheckReceiveItemJoker = true;
                    _Money5Bath.SetActive(true);

                }
                else if (SpinNumber > 45 && SpinNumber <= 63)
                {
                    CheckReceiveItemMoney10 = true;
                    _Money10Bath.SetActive(true);
                }
                else if (SpinNumber > 63 && SpinNumber <= 77)
                {
                    CheckReceiveItemFood = true;
                    _Food.SetActive(true);
                }
                else if (SpinNumber > 77 && SpinNumber <= 89)
                {
                    CheckReceiveItemMoney50 = true;
                    _Money50Bath.SetActive(true);
                }
                else if (SpinNumber > 89 && SpinNumber <= 96)
                {
                    CheckReceiveItemClothing = true;
                    _Clothing.SetActive(true);
                    _ClothingInBook.SetActive(true);
                    
                }
                else if (SpinNumber > 96 && SpinNumber <= 100)
                {
                    CheckReceiveItemSpacialClothing = true;
                    _SpacialClothing.SetActive(true);
                    _SpacialClothingInBook.SetActive(true);
                    
                }
            }
            if (Player.HappyValue == 12)
            {
                SpinNumber = Random.Range(1.0f, 100.0f);
                Debug.Log(SpinNumber);
                if (SpinNumber >= 1 && SpinNumber <= 40)
                {
                    CheckReceiveItemJoker = true;
                    _Money5Bath.SetActive(true);

                }
                else if (SpinNumber > 40 && SpinNumber <= 59)
                {
                    CheckReceiveItemMoney10 = true;
                    _Money10Bath.SetActive(true);
                }
                else if (SpinNumber > 59 && SpinNumber <= 75)
                {
                    CheckReceiveItemFood = true;
                    _Food.SetActive(true);
                }
                else if (SpinNumber > 75 && SpinNumber <= 88)
                {
                    CheckReceiveItemMoney50 = true;
                    _Money50Bath.SetActive(true);
                }
                else if (SpinNumber > 88 && SpinNumber <= 95)
                {
                    CheckReceiveItemClothing = true;
                    _Clothing.SetActive(true);
                    _ClothingInBook.SetActive(true);
         
                }
                else if (SpinNumber > 95 && SpinNumber <= 100)
                {
                    CheckReceiveItemSpacialClothing = true;
                    _SpacialClothing.SetActive(true);
                    _SpacialClothingInBook.SetActive(true);
                    
                }
            }
        }
        StartCoroutine(DelaySpinButton());
    }

    public void Close()
    {
        TutorialGuide.isGoMagic = true;
        _Roulette01.SetActive(true);
        _Roulette02.SetActive(false);
        _SpinItem_Window.SetActive(false);
        _Clothing.SetActive(false);
        _SpacialClothing.SetActive(false);

        if (CheckReceiveItemJoker == true)
        {
            _Money5Bath.SetActive(false);
            Player.money += 5;
            CheckReceiveItemJoker = false;
        }
        else if (CheckReceiveItemMoney10 == true)
        {
            _Money10Bath.SetActive(false);
            Player.money += 10;
            CheckReceiveItemMoney10 = false;
        }
        else if (CheckReceiveItemFood == true)
        {
            CheckReceiveItemFood = false;
            _Food.SetActive(false);
            if (Player.HappyValue < Player.maxHappyValue)
            {
                Player.HappyValue += 1;
            }
        }
        else if (CheckReceiveItemMoney50 == true)
        {
            _Money50Bath.SetActive(false);
            Player.money += 50;
            CheckReceiveItemMoney50 = false;
        }
        else if (CheckReceiveItemClothing == true)
        {
            _itemToEndGame01 = true;
            if (Clothing < maxClothing)
            {
                Clothing += 1;
            }
            
            if (Clothing == 2)
            {
                Player.money += 20;
            }
            CheckReceiveItemClothing = false;
        }
        else if(CheckReceiveItemSpacialClothing == true)
        {
            _itemToEndGame02 = true;
            if (SpacialClothing < maxSpacialClothing)
            {
                SpacialClothing += 1;
            }

            if (SpacialClothing == 2)
            {
                Player.money += 20;
            }
            CheckReceiveItemSpacialClothing = false;
        }
    }

    IEnumerator DelayOpenSpinWindow()
    {
        if (Check == true)
        {
            yield return new WaitForSeconds(5f);
            _Roulette01.SetActive(true);
            _Roulette02.SetActive(false);
            _SpinItem_Window.SetActive(true);
            getItemSFX.Play();
            Check = false;
        }
    }
    IEnumerator DelaySpinButton()
    {
        yield return new WaitForSeconds(5f);
        SpinButton02.SetActive(false);
    }
}
