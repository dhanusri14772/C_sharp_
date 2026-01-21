using System;
class Inline
{
    static void Main()
    {
        Func<int,int> square = x => x * x;
        Console.WriteLine(square(5));
    }
}