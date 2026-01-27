using System;
class Nulldatetime
{
    static void Main()
    {
        DateTime? dt = null;
        if (dt.HasValue)
            Console.WriteLine(dt.Value);
        else
            Console.WriteLine("No date");
    }
}
