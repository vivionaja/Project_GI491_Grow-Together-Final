using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Quest
{
    public bool CheckButton = false;

    public bool isActive;
    public bool isFinish = false;

    public string title;
    public string descrit;
    public int money = 15;
    public int happyValue = 0;

    public GoalQuest goal;

    

    public void Complete()
    {
        isActive = false;
        isFinish = true;
        Debug.Log(title + " complete");
    }
}
