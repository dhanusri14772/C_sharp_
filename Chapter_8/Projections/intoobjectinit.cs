using System;
using System.Collections.Generic;
using System.Linq;
public class TempResult
{
    public string Name;
    public int Length;
}
public class Objectinitialzer
{
    public static void Main()
    {
        string[] names = { "Tom", "Dick", "Harry" };
        IEnumerable<TempResult> query = from n in names
                                       select new TempResult
                                       {
                                           Name = n,
                                           Length = n.Length  
                                       };
        foreach (var item in query)
            Console.WriteLine($"{item.Name} has {item.Length} chars");
    }
}