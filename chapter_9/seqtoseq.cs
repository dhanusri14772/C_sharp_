using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int[] numbers = { 10, 15, 20, 25, 30, 35 };

        // 1. Sequence-to-Sequence: returns a new sequence (10, 20, 30)
        IEnumerable<int> evenNumbers = numbers.Where(n => n % 2 == 0);

        // 2. Sequence-to-Value: returns a single integer (3)
        int count = evenNumbers.Count();

        Console.WriteLine($"There are {count} even numbers.");
        
        foreach (int n in evenNumbers)
        {
            Console.Write(n + " ");
        }
    }
}