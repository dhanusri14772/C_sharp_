using System;
using System.Collections.Generic;
using System.Linq;
public class Sort
{
    public static void Main()
    {
        string[] names = {"tom","dick","harry","marie","curie","dhanu"};
        IEnumerable<string> query = names.OrderBy(n => n.Length).ThenBy(n=>n);
        foreach (string name in query) Console.WriteLine(name);
    }
}