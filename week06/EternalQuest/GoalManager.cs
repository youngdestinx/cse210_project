using System;

public class GoalManager 
{
    private List<Goal> _goals;
    private int _totalcount;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _totalcount = 0;
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
        Console.WriteLine("Goal added successfully");
    }

    public void DisplayGoal()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("Oops! No goals added yet.");
            return;
        }

        Console.WriteLine("Your current goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].DisplayGoal()}");
        }
        Console.WriteLine($"\nTotal Point: {_totalcount}\n");
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex < 0 || goalIndex >= _goals.Count)
        {
            Console.WriteLine("Invalid goal index.");
            return;
        }

        Goal selectedGoal = _goals[goalIndex];
        selectedGoal.RecordEvent();

        if (selectedGoal is ChecklistGoal checklist)
        {
            if (checklist.IsComplete())
                _totalcount += checklist.GetBonus() + checklist.GetPoint();
            else
                _totalcount += checklist.GetPoint();
        }
        else 
        {
            if (!selectedGoal.IsComplete() || selectedGoal is EternalGoal)
            _totalcount += selectedGoal.GetPoint();
        }
    }

    public void SaveGoal()
    {
        FileHandler.Save(_goals);
    }

    public void LoadGoal()
    {
        _goals = FileHandler.Load();
    }
    
}