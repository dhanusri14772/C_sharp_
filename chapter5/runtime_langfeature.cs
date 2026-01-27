using System;

class Program
{
    static void Main()
    {
        object x = 10;

        if (x is int n) //language feature nut execution happens in clruntime
            Console.WriteLine(n + 5);
    }
}
