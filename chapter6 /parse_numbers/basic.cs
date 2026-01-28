using System;
class Numericparse
{
    static void Main()
    {
        double d = double.Parse("3.5");
        Console.WriteLine(d);
        int i;
        bool ok = int.TryParse("3", out i);
        Console.WriteLine(ok);
        Console.WriteLine(i);
    }
}