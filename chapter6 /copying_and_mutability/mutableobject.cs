using System;
class Box
{
    public int Value;
}
class Program
{
    static void Main()
    {
        Box b = new Box();
        b.Value = 10;
        b.Value = 20;
        Console.WriteLine(b.Value);
    }
}
