using System;
using System.Collections.Generic;
using System.IO;

public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int point) : base(name, description, point)
    { }

    public override void RecordEvent()
    {
        if (!_IsCompleted)
        {
            _IsCompleted = true;
            Console.WriteLine($"Congratulations! Goal \"{_name}\" completed! You have received {_point} points");            
        }
        else
        {
            Console.WriteLine($"Oops! Goal \"{_name}\" has already been completed!");            
        }
    }

    public override bool IsComplete()
    {
        return _IsCompleted;
    }

    public override string DisplayGoal()
    {
        string status = _IsCompleted ? "[X]" : "[ ]";
        return $"Simple Goal: {status} {_name} ({_description}) {_point}";
    }


    public override string GetStringRepresentation()
    {
        return $"Simple Goal|{_name}|{_description}|{_point}";
    }

}