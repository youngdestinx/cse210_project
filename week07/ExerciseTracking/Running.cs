using System;

public class Running : Activity
{
    public Running(double distance, double minute, int type) : base(distance, minute, type)
    {

    }

    public override double GetDistance()
    {
        return GetDist();
    }

    public override double GetSpeed()
    {
        double Speed = (GetDist() / GetMinute()) * 60;
        return Speed;
    }

    public override double GetPace()
    {
        double Pace = GetMinute() / GetDist();
        return Pace;
    }

}
