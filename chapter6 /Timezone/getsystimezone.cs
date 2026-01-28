using System;
class Timezoneinfo
{
    static void Main()
    {
        foreach (var tz in TimeZoneInfo.GetSystemTimeZones()) //returns all the timezones installed on the os
        {
            Console.WriteLine(tz.Id);
            Console.WriteLine(tz.DisplayName);
        }
    }
}
