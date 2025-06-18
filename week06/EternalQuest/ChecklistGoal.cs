using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int point, int target, int bonus) : base(name, description, point)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public int GetBonus()
    {
        return _bonus;
    }

    public int GetPoint()
    {
        return base.GetPoint();
    }

    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            int earned = _point;
            if (_amountCompleted == _target)
            {
                _IsCompleted = true;
                earned += _bonus;
                Console.WriteLine($"Congratulations!!! Checklist completed! You have earned a bonus of {_bonus}");
                Console.WriteLine($"You have earned a total of {earned} points");
            }
            else
            {
                _IsCompleted = false;
                Console.WriteLine($"Congratulations! You have earned {_point} point for completing this step");
            }
        }
        else
        {
            Console.WriteLine("This checklist goal is already complete.");
        }
    }

    public override bool IsComplete()
    {
        return _IsCompleted;
    }

    public override string DisplayGoal()
    {
        string status = _IsCompleted ? "[X]" : "[ ]";
        return $"Checklist Goal: {status}  {_name} ({_description})  Progress: {_amountCompleted}/{_target} | Completed: {_IsCompleted}";
    }
    
    public override string GetStringRepresentation()
    {
        return $"Checklist Goal|{_name}|{_description}|{_point}|{_target}|{_bonus}";
    }
}
