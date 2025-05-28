using System;

class Program
{
    static void Main(string[] args)
    {
        Reference john = new Reference("John", 3, 16);

        string passage = "For God so love the world that he gave His only begotten son, that whosoever beliveth in Him should not persih but have everlasting life";

        Scripture book = new Scripture(john, passage);

        while (!book.IscompletelyHidden())
        {
            //Console.Clear();
            Console.WriteLine(book.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            else {
                Console.Clear();
                Console.WriteLine(book.GetDisplayText());
                Console.WriteLine("\nAll words hidden. Program ended."); 
            }
        }
        
        Console.Clear();
        Console.WriteLine(book.GetDisplayText());
        Console.WriteLine("\nAll words hidden. Program ended.");
    }
}