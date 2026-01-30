using System;
using System.Linq;
using System.Collections.Generic;
public class Multirange
{
    public static void Main()
    {
        int[] numbers = {1,2};
        string[] letters = {"a","b","c","d"};
        var query = from n in numbers
                    from l in letters
                    select n.ToString() + l;
        foreach (string s in query)
            Console.WriteLine(s); 
    }
}