using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activity = new List<Activity>();
        Running run = new Running(1000, 150, 1);
        Cycling cycle = new Cycling(1000, 50, 2);
        Swimming swim = new Swimming(1000, 250, 3, 50);
        
        activity.Add(run);
        activity.Add(cycle);
        activity.Add(swim);

        foreach (Activity act in activity)
        {
            Console.WriteLine(act.GetSummary());
        }
    }
}