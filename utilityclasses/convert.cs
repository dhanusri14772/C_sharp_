using System;

class Program
{
    static void Main()
    {
        string s = "123";

        int i = Convert.ToInt32(s);
        double d = Convert.ToDouble(i);

        Console.WriteLine(i);
        Console.WriteLine(d);
    }
}
