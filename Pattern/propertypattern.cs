using System;
class pattern
{
    public int X { get; set; }
    public int Y { get; set; }
}
class Propertypattern
{
    static void Main()
    {
        var p = new pattern { X = 0, Y = 0 }; //initializing an object
        if (p is { X: 0, Y: 0 }) //checks property x equals 0 & y equals 0
            Console.WriteLine("Origin");
    }
}
