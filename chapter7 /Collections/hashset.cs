using System;
using System.Collections.Generic;
public class hashSet
{
    public static void Main()
    {
        var letters = new HashSet<char>("the quick brown fox");
        Console.WriteLine(letters.Contains('t'));      // True
        Console.WriteLine(letters.Contains('j'));      // False
        foreach (char c in letters) Console.Write(c); 
    }
}