using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    public static void Main()
    {
        string[] names = { "Tom", "Dick", "Harry" };
        var query = from n in names
                    select new 
                    { 
                        Original = n, 
                        Upper = n.ToUpper(),
                        IsLong = n.Length > 3 
                    };
        foreach (var item in query)
            Console.WriteLine($"{item.Original} -> {item.Upper} (Long? {item.IsLong})");
    }
}