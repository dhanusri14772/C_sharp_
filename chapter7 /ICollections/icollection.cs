using System;
using System.Collections.Generic;
public class Icollection
{
    public static void Main()
    {
        ICollection<string> col = new List<string>();
        col.Add("item 1");
        col.Add("item2");
        col.Add("item3");
        Console.WriteLine($"count after removal:{col.Count}");
        string[] targetArray = new string[col.Count];
        col.CopyTo(targetArray,0);
        foreach (string s in targetArray)
               Console.WriteLine($"array item: {s}");

    }
}