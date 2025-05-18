using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Welcome to the Journal!");
        Console.WriteLine("");


        Journal journal = new Journal();


        while (true)
        {
            Console.WriteLine("What will you like to do today?\nPlease choose a number.");
            Console.WriteLine("");

            Console.WriteLine("1. Write\n2. Display\n3. Save\n4. Load\n5. Quit");
            string choice = Console.ReadLine();
            int choose = int.Parse(choice);
            Console.WriteLine("");
            
            string question1 = "What did I learn from my personal studies today?";
            string question2 = "Which experience change my paradigm of how I see the world today?";
            string question3 = "How did I use my time intelligently, powerfully, and intentionally?";
            string question4 = "What life lesson did my programming lessons teach me today?";
            string question5 = "What is the most important thing that I did today?";
            string question6 = "Which good did I go about doing today?";
            string question7 = "What am I most grateful for?";

            Prompts question = new Prompts();
            question._prompts.Add(question1);
            question._prompts.Add(question2);
            question._prompts.Add(question3);
            question._prompts.Add(question4);
            question._prompts.Add(question5);
            question._prompts.Add(question6);
            question._prompts.Add(question7);
            

            
            if (choose == 1)
            {
                Entry entry = new Entry();
                entry._date = DateTime.Now.ToString();
                entry._prompt = question.DisplayPrompt();
                Console.WriteLine(entry._prompt);
                entry._response = Console.ReadLine();
                Console.WriteLine("");

                journal.AddEntry(entry);

            }

            else if (choose == 2)
            {
                journal.Display();
                Console.WriteLine("");
            }

            else if (choose == 3)
            {
                Console.WriteLine("How will you save the file? (e.g. entry.txt)");
                string file = Console.ReadLine();
                journal.SaveToFile(file);
                Console.WriteLine("");

            }

            else if (choose == 4)
            {
                Console.Write("Enter the filename to load: ");
                string fileName = Console.ReadLine();
                journal.LoadFromFile(fileName);
                Console.WriteLine("");

            }

            else
            {
                Console.WriteLine("Thanks For Your Time Today!!");
                break;
            }
            
        }

        /*
        Entry entry = new Entry();
        entry._prompt = prompt;
        entry._response = answer;
        entry._date = DateTime.Now.ToString();

        entry.Display();

        Journal journal = new Journal();

        journal.AddEntry(entry);

        journal.Display();

        Console.WriteLine("How will you save the file? (e.g. entry.txt)");
        string file = Console.ReadLine();
        journal.SaveToFile(file);

        Console.Write("Enter the filename to load: ");
        string fileName = Console.ReadLine();
        journal.LoadFromFile(fileName);
        */
    }
}