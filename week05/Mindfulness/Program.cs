using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> descriptions = new List<string>{
            """
            This activity will help you relax by walking you through breathing in aand out slowly. clear your mind and focus on your
            breathing
            """,
            """
            This activity will help you reflect on the good things in your life by having you list as many things as you
            can in a certain area.
            """,
            """
            This activity will help you reflect on times in your life when you have shown strength and
            resilence. This will help you recognize the power that you have and how you can use it in other aspects of
            your life
            """
        };

        while (true)
        {
            Console.WriteLine("Welcome to the Mindfullness exercise.\nSelect from the menu what you will love to do.");
            Console.WriteLine("Please pick a number");
            Console.WriteLine("\n1. Breathing Activity\n2. Listing Activity\n3. Reflecting Activity\n4. Quit");
            string input = Console.ReadLine();
            int response = int.Parse(input);
            Console.WriteLine();
            
            if (response == 1)
            {
                Console.Write("How Long will you love to carry out this activty in seconds.\nPlease input a number: ");
                string number = Console.ReadLine();
                int duration = int.Parse(number);
                Console.WriteLine();

                string description = descriptions[0];
                Breathing breath = new Breathing("Breathing Activity", description, duration);
                breath.Run();
                
            }

            else if (response == 2)
            {
                Console.Write("How Long will you love to carry out this activty in seconds.\nPlease input a number: ");
                string number = Console.ReadLine();
                int duration = int.Parse(number);
                Console.WriteLine();

                string description = descriptions[1];
                Listing list = new Listing("Listing Activity", description, duration);
                list.Run();
                list.GetDisplayText();
                
            }

            else if (response == 3)
            {
                Console.Write("How Long will you love to carry out this activty in seconds.\nPlease input a number: ");
                string number = Console.ReadLine();
                int duration = int.Parse(number);
                Console.WriteLine();

                string description = descriptions[0];
                Reflecting reflect = new Reflecting("Refleting Activity", description, duration);
                reflect.Run();
                
            }

            else
            {
                Console.WriteLine("Thanks for your time!");
                return;
            }
        }
    }    
}