using System;
struct Point
{
    public int X;
}
class Program
{
    static void Main()
    {
        Point p1 = new Point();
        p1.X = 10;
        Point p2 = p1;
        p2.X = 20;
        Console.WriteLine(p1.X);
        Console.WriteLine(p2.X);
    }
}
