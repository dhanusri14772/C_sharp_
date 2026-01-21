using System;
class Trycatch
{
    static void Main()
    {
        try
        {
            int t = int.Parse("she is a fantasy..");
            Console.WriteLine(t);
        }
        catch
        {
            Console.WriteLine("invalid, check and review");
        }
    }
}