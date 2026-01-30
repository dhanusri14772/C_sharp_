using System;
using System.Collections.Generic;
using System.Linq;
public class Intokeyword
{
    public static void Main()
    {
        string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };
        var query = from n in names
                    where n.Contains("a")
                    select n.ToUpper() into temp //into keyword is used to freeze the preciding part of query into a new "temp" variable
                    where temp.Length > 3
                    select temp;
        foreach (string s in query) Console.WriteLine(s);
    }
}