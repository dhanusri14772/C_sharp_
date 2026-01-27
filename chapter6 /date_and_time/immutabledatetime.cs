using System;
class Immutabledatetime
{
    static void Main()
    {
        DateTime today = DateTime.Today;
        DateTime tomorrow = today.AddDays(1); //doesnot modify instead returns a new one
        Console.WriteLine(today);
        Console.WriteLine(tomorrow);
    }
}
