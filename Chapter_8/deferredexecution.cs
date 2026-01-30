using System;
using System.Collections.Generic;
using System.Linq;
public class Deferredexecution
{
    public static void Main()
    {
        var numbers = new List<int> {1};
        IEnumerable<int> query = numbers.Select(n=>n*10);
        numbers.Add(2);
        foreach(int n in query)  Console.WriteLine(n);
    }
}