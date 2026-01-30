using System;
using System.Collections.Generic;
using System.Linq;
public class Wrappingqueries
{
    public static void Main()
    {
        string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };
        var query = from n in (
                        from n2 in names
                        where n2.Contains("a")
                        select n2
                    )
                    orderby n.Length
                    select n.ToUpper();
        foreach (string s in query) Console.WriteLine(s);
    }
}