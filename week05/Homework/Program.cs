using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment done = new MathAssignment("Destiny Linus", "Inheritance", "7.25", "Practicing Inheritance");
        Console.WriteLine(done.GetHomeWorkList());

        WritingAssignment work = new WritingAssignment("Miracle Linus", "YouTube", "Understanding YouTube Thumbnails");
        Console.WriteLine(work.GetWritingInformation());
    }
}