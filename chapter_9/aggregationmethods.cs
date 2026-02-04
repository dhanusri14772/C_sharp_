using System;
using System.Collections.Generic;
using System.Linq;
public class Aggregationmethod
{
    public static void Main()
    {
        int[] numbers = {1,2,3,4,5};
        int count = numbers.Count();
        int sum = numbers.Sum();
        int max = numbers.Max();
        double avg = numbers.Average();
        int evencount = numbers.Count(n => n%2 == 0);
        Console.WriteLine($"count : {count}, sum : {sum}, max: {max}, average :{avg}");
        Console.WriteLine($"evens only :{evencount}");
    }
}