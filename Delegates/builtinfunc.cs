using System;
class Func
{
    static void Main()
    {
        Func<int, int, int> add = (x,y) => x+y;
        Console.WriteLine(add(109023,464257));
    }
}