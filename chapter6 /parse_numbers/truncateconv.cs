using System;
class Truncateconv
{
    static void Main()
    {
        int i1 = 23; //implicit cast , no data loss
        double d1 = i1;
        Console.WriteLine(d1);
        double d2 = 23.5;
        int i2 = (int)d2; //explicit cast , decimal part gets removed - truncation
        Console.WriteLine(i2);
    }
}