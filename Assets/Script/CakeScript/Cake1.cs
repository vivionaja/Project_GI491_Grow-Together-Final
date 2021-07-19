using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cake1 : MonoBehaviour
{
    //public int maxHappyValue;
    public int HappyValue;
    public int CakePrice;

    private void OnMouseOver()
    {
        if (Player.HappyValue < Player.maxHappyValue)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (Player.money >= CakePrice)
                {
                    Player.HappyValue += HappyValue;
                    Player.money -= CakePrice;
                    Debug.Log(HappyValue);
                    if (Player.HappyValue > Player.maxHappyValue)
                    {
                        Player.HappyValue = 12;
                    }
                }
            }
        }
    }
}
