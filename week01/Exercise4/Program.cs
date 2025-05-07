using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a lists of numbers, type 0 when finished.");
        
        while (true)
        {
            Console.Write("Enter a number: ");
            string seriesOfNumbers = Console.ReadLine();
            int number = int.Parse(seriesOfNumbers);

            numbers.Add(number)
        

            if (number == 0)
            {
                break;
            }
        }

        int total = numbers.
    }
}