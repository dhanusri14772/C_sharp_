using System;
class Program
{
    unsafe static void Main()
    {
        int x = 42;
        void* p = &x; //pointer with no type info
        int* ip = (int*)p; //casting void pointer to integer
        Console.WriteLine(*ip);
    }
}
