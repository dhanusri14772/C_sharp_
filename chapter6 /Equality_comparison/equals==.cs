using System;
class equals
{
    static void Main()
    {
        double x = double.NaN;
        Console.WriteLine(x == x);
        Console.WriteLine(x.Equals(x));
    }
}