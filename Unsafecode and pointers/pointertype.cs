using System;
class Program
{
    unsafe static void Main()
    {
        int x = 5;
        int* p = &x;
        *p = 20;
        Console.WriteLine(x);
    }
}
