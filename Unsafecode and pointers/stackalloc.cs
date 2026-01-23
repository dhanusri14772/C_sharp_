using System;
class Program
{
    unsafe static void Main()
    {
        int* p = stackalloc int[5];
        for (int i = 0; i < 5; i++)
            p[i] = i * 10;
        for (int i = 0; i < 5; i++)
            Console.WriteLine(p[i]);
    }
}
