using System;

public class ChecklistGoal : Goal
{
    private int _amount;
    private int _currentAmount;
    private int _bonus;
    public ChecklistGoal(string name, string description, int worth, int amount, int bonus) : base(name, description, worth)
    {
        _amount = amount;
        _bonus = bonus;
    }

    public override string DisplayGoal()
    {
        string name = GetName();
        string description = GetDescription();
        int worth = GetWorth();
        string isComplete = GetIsComplete() ? "[X]" : "[ ]";

        return (isComplete + " " + name + " (" + description + ")" + " -- Currently compeleted: " + _currentAmount + "/" + _amount);
    }

    public override int CompleteGoal()
    {
        _currentAmount++;
        if (_currentAmount >= _amount)
        {
            SetIsComplete(true);
            return GetWorth() + _bonus;
        }
        return GetWorth();
    }

    public override string SaveGoal()
    {
        string name = GetName();
        string description = GetDescription();
        int worth = GetWorth();
        bool isComplete = GetIsComplete();

        return ("ChecklistGoal|" + name + "|" + description + "|" + worth + "|" + isComplete + "|" + _amount + "|" + _currentAmount + "|" + _bonus);
    }
}