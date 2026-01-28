using System;
class Convtimezone
{
    static void Main()
    {
        DateTime utcNow = DateTime.UtcNow;
        TimeZoneInfo india =
            TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
        DateTime indiaTime =
            TimeZoneInfo.ConvertTimeFromUtc(utcNow, india); //convertingtimezone from utc to india
        TimeZoneInfo newYork =
            TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
        DateTime nyTime =
            TimeZoneInfo.ConvertTime(indiaTime, india, newYork); //converting from indian time to newyork time 
        Console.WriteLine($"UTC Time: {utcNow}");
        Console.WriteLine($"India Time: {indiaTime}");
        Console.WriteLine($"New York Time: {nyTime}");
    }
}
