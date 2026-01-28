using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 5, 2, 9, 1 };

        Array.Sort(numbers);

        Console.WriteLine("Sorted:");
        foreach (int n in numbers)
            Console.WriteLine(n);

        Array.Reverse(numbers);

        Console.WriteLine("Reversed:");
        foreach (int n in numbers)
            Console.WriteLine(n);

        int index = Array.IndexOf(numbers, 5);
        Console.WriteLine("Index of 5: " + index);
    }
}
