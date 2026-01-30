using System;
using System.Collections.Generic;
using System.Linq;
public class Subqueryinqes
{
    public static void Main()
    {
        string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };
        var query = from n in names
                    where n.Length == (from n2 in names select n2.Length).Min() //subquery
                    select n;
        foreach (string name in query)
            Console.WriteLine(name);
    }
}