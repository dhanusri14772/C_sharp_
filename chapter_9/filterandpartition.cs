using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int[] numbers = { 09, 08,10, 20, 30, 40, 50, 60, 70, 80 };
        var filtered = numbers.Where(n => n > 20);
        var skipped = filtered.Skip(2);
        var finalResult = skipped.Take(2);
        Console.WriteLine("Final filtered and partitioned result:");
        var takeResult = numbers.TakeWhile(n => n < 10);
        var skipResult = numbers.SkipWhile(n => n < 10);
        foreach (int n in finalResult)
        {
            Console.WriteLine(n);
        }
        foreach (int n in takeResult)
        {
            Console.WriteLine(n);
        }
        foreach (int n in skipResult)
        {
            Console.WriteLine(n);
        }
    }
}