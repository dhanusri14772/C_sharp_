using System;
using System.Collections.Generic;
class Infiniteseq
{
    static IEnumerable<int> Infinite()
    {
        int i = 0;
        while (true)
            yield return ++i;
    }
    static void Main()
    {
        foreach (int n in Infinite())
        {
            Console.WriteLine(n);
            if (n == 5) break;
        }
    }
}
