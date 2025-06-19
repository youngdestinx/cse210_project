using System;

public class Swimming : Activity
{
    private double _laps;

    public Swimming(double distance, double minute, int type, double laps) : base(distance, minute, type)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        double distance = _laps * 50 / 1000 * 0.62;
        return distance;
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
