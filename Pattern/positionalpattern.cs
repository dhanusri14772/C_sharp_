using System;
record pattern (int X, int Y);
class Positional
{
    static void Main()
    {
        var p = new pattern(0, 0);
        if (p is (0, 0)) //matches constructor positions of record
            Console.WriteLine("yes it is from Origin");
    }
}
