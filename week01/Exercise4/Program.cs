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

            numbers.Add(number);
            numbers.Remove(0);
        

            if (number == 0)
            {
                break;
            }
        }

        int sum = numbers.Sum();
        Console.WriteLine($"The sum is: {sum}");

        double average = numbers.Average();
        Console.WriteLine($"The average is: {average}");

        int largest = numbers.Max();
        Console.WriteLine($"The largest number is: {largest}");
    }
}