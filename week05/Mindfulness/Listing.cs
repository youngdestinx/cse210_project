using System;

public class Listing : Activity
{
    private List<string> _propmt = new List<string>();
    private List<string> _question = new List<string>();

    public Listing(string name, string description, int duration) : base(name, description, duration)
    {
        _propmt.Add("Who are the people that you appreciate?");       
        _propmt.Add("What are some personal strength of yours?");
        _propmt.Add("Who are the people that you have helped this week?");
        _propmt.Add("When have you felt the HolyGhost this week?");
        _propmt.Add("Who are some of your personal heroes?");

        base.DisplayStartingMessage();
    }

    public void GetRandomPromt() 
    { 
        Random rand = new Random();
        string chosenWord = _propmt[rand.Next(0, _propmt.Count)];
        Console.WriteLine(chosenWord);
    }

    public void Run()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        Thread.Sleep(2000);

        base.ShowSpinner();
        Console.WriteLine();
        GetRandomPromt();
        base.CountDown();
        string response = Console.ReadLine();
        _question.Add(response);
        Console.WriteLine();

        while (true)
        {
            DateTime currentTime = DateTime.Now;
            if (currentTime < futureTime)
            {
                List<string> prompt = new List<string>{"Consider a person, character or impression that change your life",
                "Think of moment you were down, who console you?", 
                "Recall how you feel and what was the feeling and impression?", "What would you do to help others?",
                "How has your testimony grown because of this experience"};

                Random rand = new Random();
                string chosenWord = prompt[rand.Next(0, prompt.Count)];
                Console.WriteLine(chosenWord);
                base.CountDown();
                string answer = Console.ReadLine();
                _question.Add(answer);
                Console.WriteLine();
            }
            else 
            {
                break;
            }

        }
    }

    public void GetDisplayText()
    {
        int number = _question.Count;

        Console.WriteLine($"Congratulations!");
        base.ShowSpinner();
        Console.WriteLine($"You entered {number} responses");

        base.DisplayEndingMessage();              
    }
}