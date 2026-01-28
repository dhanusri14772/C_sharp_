using System;
class Structequality
{
    static void Main()
    {
        var dt1 = new DateTimeOffset(2010, 1, 1, 1, 1, 1, TimeSpan.FromHours(8));
        var dt2 = new DateTimeOffset(2010, 1, 1, 2, 1, 1, TimeSpan.FromHours(9));
        Console.WriteLine(dt1 == dt2);
    }
}