using System;

class Program
{
    static void Print<T>(T value)
    {
        Console.WriteLine(value);
    }

    static void Main()
    {
        Print<int>(10);
        Print<string>("Hello");
        Print<double>(3.14);
    }
}
