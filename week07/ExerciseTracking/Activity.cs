using System;

public abstract class Activity
{
    private double _distance;
    private double _minute;
    private string _type;

    public Activity(double distance, double minute, int num)
    {
        _distance = distance;
        _minute = minute;

        switch (num)
        {
            case 1:
                _type = "Running";
                break;
            
            case 2:
                _type = "Cycling";
                break;

            case 3:
                _type = "Swimming";
                break;

            default:
                Console.WriteLine("Invalid type! Pls try again");
                break;
        }
    }

    public string GetDate()
    {
        Console.Write("Enter a date: ");
        string date = Console.ReadLine();
        return $"{date}";
    }

    public double GetDist()
    {
        return _distance;
    }

    public double GetMinute()
    {
        return _minute;
    }

    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();

    public string GetSummary()
    {
        return $"{GetDate()} {_type}({GetMinute()}mins)-Distance {GetDistance()}miles, Speed {GetSpeed()}mph, Pace: {GetPace()}min per mile";
    }
}