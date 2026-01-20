using System;
using System.Collections.Generic;
class Predicate
{
    static void Main()
    {
        Predicate<int> isEven = x => x%2 == 0;
        Console.WriteLine(isEven(10));
    }
}