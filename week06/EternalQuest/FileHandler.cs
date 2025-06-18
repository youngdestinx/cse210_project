using System;
using System.Collections.Generic;
using System.IO;

public static class FileHandler
{
    private static string FilePath = "goals.txt";

    public static void Save(List<Goal> goals)
    {
        using (StreamWriter writer = new StreamWriter(FilePath))
        {
            foreach (Goal goal in goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved succesfully.");
    }

    public static List<Goal> Load()
    {
        List<Goal> goals = new List<Goal>();
        
        if(!File.Exists(FilePath))
        {
            Console.WriteLine("No saved goals file found.");
            return goals;
        }

        string [] lines = File.ReadAllLines(FilePath);
        
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            string type = parts[0];

            switch (type)
            {
                case "Simple Goal" :
                    SimpleGoal simple = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                    goals.Add(simple);
                    break;
                
                case "Eternal Goal" :
                    EternalGoal eternal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
                    goals.Add(eternal);
                    break;
                
                case "Checklist Goal" :
                    ChecklistGoal checklist = new ChecklistGoal(
                        parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]));
                    goals.Add(checklist);
                    break;

                default:
                    Console.WriteLine($"Unknown goal type: {type}");
                    break;
            }
        }

        Console.WriteLine("Goals loaded successfully");
        return goals;
    }
}