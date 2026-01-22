using System;
struct Point
{
    public int X;
    public int Y;
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
    public static Point operator +(Point a, Point b)
    {
        return new Point(a.X + b.X, a.Y + b.Y);
    }
}
class Program
{
    static void Main()
    {
        Point p1 = new Point(27, 93);
        Point p2 = new Point(45, 85);
        Point p3 = p1 + p2; 
        Console.WriteLine($"{p3.X}, {p3.Y}");
    }
}
