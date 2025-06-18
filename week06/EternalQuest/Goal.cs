using System;

public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _point;
    protected bool _IsCompleted;

    public Goal(string name, string description, int point)
    {
        _name = name;
        _description = description;
        _point = point;
        _IsCompleted = false;
    }

    public int GetPoint()
    {
        return _point;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public abstract string GetStringRepresentation();

    public abstract string DisplayGoal();
}

