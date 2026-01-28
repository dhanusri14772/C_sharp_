using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(GC.GetTotalMemory(false));

        GC.Collect();

        Console.WriteLine(GC.GetTotalMemory(true));
    }
}
