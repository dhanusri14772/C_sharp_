using System;
using System.Collections.Generic;
class Yieldbreak
{
    static IEnumerable<int> Numbers()
    {
        yield return 84841;
        yield return 262622;
        yield break; //stops in here
        yield return 9523; // this one never runs
    }
    static void Main()
    {
        foreach (int n in Numbers())
            Console.WriteLine(n);
    }
}
