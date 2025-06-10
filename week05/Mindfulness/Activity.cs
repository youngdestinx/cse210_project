using System;

public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name)
    {
        _name = name;
    }

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }


    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}\n{_description}");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Well-done! You have completed the {_name}");
        Thread.Sleep(1500);
        ShowSpinner();
        Console.WriteLine($"You finished this activity in {_duration}sec");
        Thread.Sleep(1000);
        ShowSpinner();
        Console.WriteLine("Thanks for your time.");
    }

    public void ShowSpinner()
    {
        string[] symbols = {".", "..", "...", "....", "....."};
        for(int i = 0; i < symbols.Length; i++)
        {
            Console.Write("\r" + symbols[i]);
            Thread.Sleep(500);
        }
        Console.WriteLine("\n");

    }

    public void CountDown()
    {
        for (int i = 5; i >= 0; i--)
        {
            Console.Write("\r" + i);
            Thread.Sleep(1000);
        }
        Console.WriteLine("\n");
    }
}