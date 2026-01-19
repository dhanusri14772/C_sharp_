using System;

abstract class Shape
{
    public abstract double Area();
}

class Square : Shape
{
    public double Side = 5;

    public override double Area()
    {
        return Side * Side;
    }
}

class Program
{
    static void Main()
    {
        Shape s = new Square();
        Console.WriteLine(s.Area());
    }
}
