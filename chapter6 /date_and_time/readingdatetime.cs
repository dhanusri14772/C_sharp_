using System;
class Readdatetime
{
    static void Main()
    {
        DateTime dt = new DateTime(2000, 2, 3, 10, 20, 30);
        Console.WriteLine(dt.Year);
        Console.WriteLine(dt.Month);
        Console.WriteLine(dt.Day);
        Console.WriteLine(dt.Hour);
        Console.WriteLine(dt.Minute);
        Console.WriteLine(dt.Second);
    }
}
