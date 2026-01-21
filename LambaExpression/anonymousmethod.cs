using System;
class Anonymousold
{
    static void Main()
    {
        Func<int,int> square = delegate (int x)
        {
            return x*x;
        };
        Console.WriteLine(square(46054));
    }
}