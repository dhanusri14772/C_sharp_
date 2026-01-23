#define TEST
using System;
class elseif
{
    static void Main()
    {
#if DEBUG
        Console.WriteLine("Debug");
#elif TEST
        Console.WriteLine("Test");
#else
        Console.WriteLine("Release");
#endif
    }
}
