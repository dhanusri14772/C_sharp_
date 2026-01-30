using System;
using System.Collections.Generic;
using System.Linq;
public class Fluent
{
    public static void Main()
    {
        string[] names = {"dhanusri", "joshnavi","ikramuddeen","aseem sherrif", "syedasif", "prathinksha"};
        IEnumerable<string> query = names.Where (n => n.Contains("a")).OrderBy(n => n.Length).Select(n => n.ToUpper());
        foreach (string name in query )  Console.WriteLine(name);
    }
 }