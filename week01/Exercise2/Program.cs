using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? (eg: 70) ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);

        string letter = "";

        if (grade >= 90)
        {
          letter = "A";
        }

        else if (grade >= 80)
        {
          letter = "B";
        }

        else if (grade >= 70)
        {
          letter = "C";
        }

        else if (grade >= 60)
        {
          letter = "D";
        }

        else 
        {
          letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}.");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations you passed the course!");
        }

        else
        {
            Console.WriteLine("Sorry, but you failed the course, please try again next time");
        }

    }
    
}