using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int point) : base(name, description, point)
    {
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {_point} points for doing \"{_name}\" ");
    }
 
    public override bool IsComplete()
    {
        return false;
    }

    public override string DisplayGoal()
    {
        return $"Eternal Goal: {_name} ({_description}) {_point}";
    }

    public override string GetStringRepresentation()
    {
        return $"Eternal Goal|{_name}|{_description}|{_point}";
    }
}