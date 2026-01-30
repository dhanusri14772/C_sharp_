using System;
using System.Collections.Generic;
using System.Linq;
public class ImmediateExecution
{
    public static void Main()
    {
        var numbers = new List<int> {1,2,3,4,5,6,7};
        List<int> result = numbers.Select(n => n * 10).ToList();
        numbers.Add(10);
        foreach (int num in result) Console.WriteLine(num);
        Console.WriteLine(result.Count);
    }
}