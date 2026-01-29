using System;
using System.Collections.Generic;
public class Dictionary
{
    public static void Main()
    {
        var d = new Dictionary<string , int> {["banana"] = 2 ,["apple"] = 4 , ["cherry"] = 5};
        d["tea leaves"] = 9;
        d["yummy food"] = 58;
        d["hashes"] = 76;
        Console.WriteLine(d["banana"]);
        bool hasApple = d.ContainsKey("apple");
        Console.WriteLine($"Has apple? {hasApple}"); 
        foreach (KeyValuePair<string, int> kvp in d)
        Console.WriteLine(kvp.Key + ": " + kvp.Value);
    }
}