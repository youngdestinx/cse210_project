using System;

public class Breathing : Activity
{
    public Breathing(string name, string description, int duration) : base(name, description, duration)
    {
        _duration = duration;
        base.DisplayStartingMessage();
    }

    public void Run()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        Thread.Sleep(2000);

        while (true)
        {
            DateTime currentTime = DateTime.Now;
            if (currentTime < futureTime)
            {
                base.ShowSpinner();
                Console.WriteLine();

                Console.WriteLine("\nBreathe in...");
                base.CountDown();
                Console.WriteLine();

                base.ShowSpinner();
                Console.WriteLine("\nBreathe out...");
                base.CountDown();
            }
            else 
            {
                base.DisplayEndingMessage();
                break;
            }
        }
    }
}
