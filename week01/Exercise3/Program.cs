using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int number = random.Next(1, 101);

        while (true)
        {
            Console.WriteLine("What is your guess? ");
            string guess = Console.ReadLine();
            int guessNumber = int.Parse(guess);

            if (guessNumber > number)
            {
                Console.WriteLine("The guess is higher");
            }

            else if (guessNumber < number)
            {
                Console.WriteLine("The guess is lower");
            }

            else
            {
                Console.WriteLine("The guess is correct");
                break;
            }
        }
    }
}