using System;
record point(int X, int Y);
class Nondestructive
{
    static void Main()
    {
        var p1 = new point(3, 4);
        var p2 = p1 with { X = 10 }; //creates 
        Console.WriteLine(p1);
        Console.WriteLine(p2);
    }
}
