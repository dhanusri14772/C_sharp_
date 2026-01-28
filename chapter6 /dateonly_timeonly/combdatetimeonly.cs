using System;
class Datetime
{
    static void Main()
    {
        DateOnly date = new DateOnly(2024, 1, 27);
        TimeOnly time = new TimeOnly(14, 45);
        DateTime combined = date.ToDateTime(time);
        Console.WriteLine(combined);
    }
}

