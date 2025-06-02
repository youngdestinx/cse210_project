using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Scripture Memorizer");

        Console.WriteLine("Enter the text of the scripture to memorize:");
        string passage = Console.ReadLine();
        Console.WriteLine();
        
        Reference john = new Reference("John", 3, 16);
        Word text = new Word(passage);
        Scripture word = new Scripture(john, text);

        Console.WriteLine(word.GetDisplayText());
        Console.WriteLine();
        
        while (true)
        {
            Console.Write("Type 'quit' to end the program but tap 'Enter' to continue: ");
            string input = Console.ReadLine();
            Console.Clear();

            if (input == "quit")
            {
                Console.WriteLine("Thanks for your time, bye!");
                break;
            }

            else if (input == "")
            {
                word.HideRandomWords();

                if (word.IscompletelyHidden())
                {
                    Console.WriteLine("Congratulations! All words are now hidden. Goodbye");
                    break;
                }
            }

            else
            {
                Console.WriteLine("Invalid command, please type 'quit' or tab the enter key.\nTry again");
                break;
            } 
        }
         
    }
}