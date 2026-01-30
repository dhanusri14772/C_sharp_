using System;
using System.Collections.Generic;
using System.Linq;
public class Progressive
{
    public static void Main()
    {
        string[] names = {"dhanusri","hariss","kishore","thenisha"};
        IEnumerable<string> filtered = names.Where(n=> n.Contains("a"));
        IEnumerable<string> sorted = filtered.OrderBy(n=> n.Length); //sorting already filtered data
        IEnumerable<string> finalquery = sorted.Select(n=> n.ToUpper());
        foreach (string n in finalquery) Console.WriteLine(n);
    }
}