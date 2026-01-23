using System;

class Pointer
{
    unsafe static void Main()
    {
        int x = 10;
        int* p = &x;

        Console.WriteLine(*p);
    }
}

