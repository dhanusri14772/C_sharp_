using System;
class Timeonly
{
    static void Main()
    {
        TimeOnly Time = new Time(9,30);
        Console.WriteLine(Time);
        Console.WriteLine(Time.Hour);
        Console.WriteLine(Time.Minute);
    }
}