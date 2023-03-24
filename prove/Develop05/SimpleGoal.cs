using System;

public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int worth) : base(name, description, worth)
    {

    }

    public override string DisplayGoal()
    {
        string name = GetName();
        string description = GetDescription();
        int worth = GetWorth();
        string isComplete = GetIsComplete() ? "[X]" : "[ ]";

        return (isComplete + " " + name + " (" + description + ")");
    }

    public override int CompleteGoal()
    {
        SetIsComplete(true);
        return GetWorth();
    }

    public override string SaveGoal()
    {
        string name = GetName();
        string description = GetDescription();
        int worth = GetWorth();
        bool isComplete = GetIsComplete();

        return ("SimpleGoal|" + name + "|" + description + "|" + worth + "|" + isComplete);
    }
}