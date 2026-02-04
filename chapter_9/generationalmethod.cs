using System;
using System.Collections.Generic;
using System.Linq;
public class Generationalmethod
{
    public static void Main()
    {
        IEnumerable<int> range = Enumerable.Range (5,10);
        foreach (int n in range) Console.Write(n+" ");
        Console.WriteLine();
        IEnumerable<string> repeated = Enumerable.Repeat("hi", 3);
        foreach (string s in repeated) Console.Write(s+" ");
    }
}