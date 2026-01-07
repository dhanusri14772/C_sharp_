using System;

public class Point
 {
     public int X; 
     public int y;
}
class Program
{
    static void Main()
    {
Point p1 = new Point();
p1.X = 7;
Point p2 = p1;              // Assignment causes copy
Console.WriteLine (p1.X); 
Console.WriteLine (p2.X); 
p1.X = 9; // Changing value
Console.WriteLine (p1.X); 
Console.WriteLine (p2.X); }
}