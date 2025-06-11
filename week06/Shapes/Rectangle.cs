using System;

public class Rectangle : Shape
{
    private double _breadth;
    private double _length;

    public Rectangle(string color, double breadth, double length) : base(color)
    {
        _breadth = breadth;
        _length = length;
    }

    public override double GetArea()
    {
        return _breadth * _length;
    }
}