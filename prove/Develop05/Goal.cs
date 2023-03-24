using System;

public abstract class Goal
{
    private string _name;
    private string _description;
    private int _worth;
    private bool _isComplete;

    public Goal(string name, string description, int worth)
    {
        _name = name;
        _description = description;
        _worth = worth;
        _isComplete = false;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetWorth()
    {
        return _worth;
    }

    public string GetName()
    {
        return _name;
    }

    public bool GetIsComplete()
    {
        return _isComplete;
    }

    public void SetIsComplete(bool isComplete)
    {
        _isComplete = isComplete;
    }

    public void SetWorth(int worth)
    {
        _worth = worth;
    }

    public abstract string DisplayGoal();
    public abstract int CompleteGoal();
    public abstract string SaveGoal();
}