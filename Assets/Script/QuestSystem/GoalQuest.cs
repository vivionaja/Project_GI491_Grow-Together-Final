using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class GoalQuest 
{
    public GoalType goalType;

    public int requiredAmount;
    public int currentAmount;

    public bool IsReached()
    {
        return (currentAmount >= requiredAmount);
    }

    public void DishWash ()
    {
        if (goalType == GoalType.wash)
            currentAmount++;
    }

    public void Water()
    {
        if (goalType == GoalType.water)
            currentAmount++;
    }
    public void Brush()
    {
        if (goalType == GoalType.brush
)
            currentAmount++;
    }
    public void Bath()
    {
        if (goalType == GoalType.bath)
            currentAmount++;
    }
    public void Buy()
    {
        if (goalType == GoalType.buy)
            currentAmount++;
    }
    public void Eat()
    {
        if (goalType == GoalType.eat)
            currentAmount++;
    }
    public void Rub()
    {
        if (goalType == GoalType.rub)
            currentAmount++;
    }
    public void Pick()
    {
        if (goalType == GoalType.pick)
            currentAmount++;
    }
    public void Sweep()
    {
        if (goalType == GoalType.sweep)
            currentAmount++;
    }
}

public enum GoalType
{
    wash,buy, bath, brush, eat, sweep, rub, pick, water
}
