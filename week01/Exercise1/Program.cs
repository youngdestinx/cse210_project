using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();
        string formattedFirstName = firstName.Substring(0, 1).ToUpper() + firstName.Substring(1).ToLower();

        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();
        string formattedLastName = lastName.Substring(0, 1).ToUpper() + lastName.Substring(1).ToLower();

        Console.WriteLine($"Your name is {formattedLastName}, {formattedFirstName} {formattedLastName}.");
    }
}