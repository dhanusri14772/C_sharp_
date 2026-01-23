#define DEBUG
using System;
class Defundef
{
    static void Main()
    {
#if DEBUG
        Console.WriteLine("Debug mode");
#endif
        Console.WriteLine("Program running");
    }
}
