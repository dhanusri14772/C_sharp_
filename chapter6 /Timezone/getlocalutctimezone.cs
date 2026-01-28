using System;
class Getlocalutc
{
    static void Main()
    {
        TimeZoneInfo local = TimeZoneInfo.Local;
        TimeZoneInfo utc = TimeZoneInfo.Utc;
        Console.WriteLine(local.Id);
        Console.WriteLine(local.DisplayName);
        Console.WriteLine(utc.Id);
        Console.WriteLine(utc.DisplayName);
    }
}
