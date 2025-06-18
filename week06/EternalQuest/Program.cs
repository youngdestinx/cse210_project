using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        bool exit = false;

        while (!exit)  
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Goal Creator And Tracker Game");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Goal Event");
            Console.WriteLine("4. Save Goal");
            Console.WriteLine("5. Load Goal");
            Console.WriteLine("6. Exit");
            Console.Write("\nSelect an option (1-6) ");

            string input = Console.ReadLine();
            Console.Clear();

            switch (input)
            {
                case "1":
                    CreateGoal(goalManager);
                    break;

                case "2":
                    goalManager.DisplayGoal();
                    Pause();
                    break;

                case "3":
                    goalManager.DisplayGoal();
                    Console.Write("\nEnter the number of the goal to record: ");
                    if (int.TryParse(Console.ReadLine(), out int index))
                    {
                        goalManager.RecordEvent(index - 1);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input.");
                    }
                    Pause();
                    break;

                case "4":
                    goalManager.SaveGoal();
                    Pause();
                    break;

                case "5":
                    goalManager.LoadGoal();
                    Pause();
                    break;

                case "6":
                    exit = true;
                    Console.WriteLine("Thanks for your time");
                    Console.WriteLine("Exiting... Goodbye!");
                    break;
                
                default :
                    Console.WriteLine("Invalid option. Try again");
                    Pause();
                    break;
            }
        }
    }

    static void CreateGoal(GoalManager goalManager)
    {
        Console.WriteLine("Select the type of goal:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Your choice: ");
        string type = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();

        Console.Write("Enter point value: ");
        string points = Console.ReadLine();
        int point = int.Parse(points);

        Goal newGoal = null;

        switch (type)
        {
            case "1" :
                newGoal = new SimpleGoal(name, description, point);
                break;
        
            case "2" :
                newGoal = new EternalGoal(name, description, point);
                break;

            case "3" :
                Console.Write("How many times must this be completed? ");
                int required = int.Parse(Console.ReadLine());

                Console.Write("What is the bonus for completing it? ");
                int bonus = int.Parse(Console.ReadLine());

                newGoal = new ChecklistGoal(name, description, point, required, bonus);
                break;

            default:
                Console.WriteLine("Invalid goal type");
                Pause();
             return;
        }

        goalManager.AddGoal(newGoal);
        Console.WriteLine("Goal created successfully!");
        Pause();
    }

    static void Pause()
    {
        Console.WriteLine("\nPress Enter to continue...");
        Console.ReadLine();
    }
}


