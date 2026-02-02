using System;
using System.Linq;
using System.Collections.Generic;
public class Groupjoin
{
    public static void Main()
    {
        int[] numbers = {3,5};
        string[] words = {"one","two","three","four"};
        var query = numbers.GroupJoin(words, n=> n, w => w.Length, (n, matches) => new {n , matches});
        foreach (var row in query)
        {
            Console.WriteLine("Length" + row.n + ":");
            foreach (string word in row.matches)
                    Console.WriteLine("-" + word);
        }
    }
}