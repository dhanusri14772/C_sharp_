using System ;using System;
using System.Collections.Generic;
using System.Linq;
public class Subquery
{
    public static void Main()
    {
        string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };

        IEnumerable<string> query = names
            .Where(n => n.Length == names.Max(n2 => n2.Length)); //subquery 
        foreach (string name in query) Console.WriteLine(name);
            
    }
}