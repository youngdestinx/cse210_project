using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("red", 9.9));
        shapes.Add(new Rectangle("black", 5.7, 8.5));
        shapes.Add(new Circle("blue", 6.8));

        foreach (var shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
            Console.WriteLine("\n");
        }
    }
}