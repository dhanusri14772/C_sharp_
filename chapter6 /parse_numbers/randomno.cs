using System;
class Randomnumber
{
    static void Main()
    {
        Random r1 = new Random(1);
        Random r2 = new Random(1);
        Console.WriteLine(r1.Next(100));
        Console.WriteLine(r2.Next(100));
        Random r = new Random();
        Console.WriteLine(r.NextDouble());
    }
}