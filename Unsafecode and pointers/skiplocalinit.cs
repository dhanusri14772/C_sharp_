using System;
using System.Runtime.CompilerServices;
class Program
{
    [SkipLocalsInit] //says runtime not to clear memeory 
    unsafe static void Main()
    {
        int* p = stackalloc int[3];
        
        Console.WriteLine(p[0]);
        Console.WriteLine(p[1]);
        Console.WriteLine(p[2]);
    }
}
