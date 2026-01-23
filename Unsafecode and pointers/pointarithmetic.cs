using System;

class Program
{
    unsafe static void Main()
    {
        int* p = stackalloc int[3];

        p[0] = 10;
        p[1] = 20;
        p[2] = 30;

        Console.WriteLine(*(p + 1)); //moves to next element 
    }
}
