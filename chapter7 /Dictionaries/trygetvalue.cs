using System;
using System.Collections.Generic;
public class Trygetvalue
{
    public static void Main()
    {
        var d = new Dictionary<string, int> { ["one"] = 1, ["two"] = 2 };
        if (d.TryGetValue("one", out int val))
            Console.WriteLine($"Found: {val}"); 
        else
            Console.WriteLine("Not found");
    }
}