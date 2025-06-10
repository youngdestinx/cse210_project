using System;

public class Reflecting : Activity
{
    public List<string> _propmt = new List<string>();
    public List<string> _question = new List<string>();

    public Reflecting(string name, string description, int duration) : base(name, description, duration)
    {
        _propmt.Add("Think of a time when you stood up for someone else");
        _propmt.Add("Think of a time you did something really difficult");
        _propmt.Add("Think of a time when you helped someone in need");
        _propmt.Add("Think of a time when you did something really selfless");

        _question.Add("Why was this experience meaningful to you?");
        _question.Add("Have you ever done anything like this before?");
        _question.Add("How did you feel when it was complete?");
        _question.Add("What made the differece than other times when you were not as successful?");
        _question.Add("What did you learn from this experience that applies to other areas of your life?");
        _question.Add("What did you learn about yourself through this experience?");

        base.DisplayStartingMessage();
    }

    public void GetRandomPrompt() 
    { 
        Random rand = new Random();
        string chosenWord = _propmt[rand.Next(0, _propmt.Count)];
        Console.WriteLine(chosenWord);
    }

    public void GetRandomQuestion() 
    { 
        Random rand = new Random();
        string chosenWord = _question[rand.Next(0, _propmt.Count)];
        Console.WriteLine(chosenWord);
    }

    public void Run()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        Thread.Sleep(2000);

        base.ShowSpinner();
        GetRandomPrompt();
        base.CountDown();
        Console.WriteLine();

        while (true)
        {
            DateTime currentTime = DateTime.Now;
            if (currentTime < futureTime)
            {
                GetRandomQuestion();
                Thread.Sleep(1000);
                base.ShowSpinner();
                Thread.Sleep(1000);
            }
            else 
            {
                break;
            }

        }

        base.DisplayEndingMessage();
    }
}