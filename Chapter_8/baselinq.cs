using System;
using System.Collections.Generic;
using System.Linq;
public class Baselinq
{
    public static void Main()
    {
        string[] names = {"tom","dick","harry"};
        IEnumerable<string> filterednames = names.Where(n.Length >= 4); 
        foreach (string n in filterednames)
        {
            Console.WriteLine(n);
        }
    }
}
