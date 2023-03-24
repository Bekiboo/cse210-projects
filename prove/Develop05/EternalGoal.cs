using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int worth) : base(name, description, worth)
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
        return GetWorth();
    }

    public override string SaveGoal()
    {
        string name = GetName();
        string description = GetDescription();
        int worth = GetWorth();
        bool isComplete = GetIsComplete();

        return ("EternalGoal|" + name + "|" + description + "|" + worth + "|" + isComplete);
    }
}