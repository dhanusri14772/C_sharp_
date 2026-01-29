using System;
public class Staticmethod
{
    public static void Main()
    {
        string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };
        Array.Sort(names);
        Console.WriteLine("Sorted names:");
        foreach (string n in names) Console.Write(n + " ");  
        int index = Array.BinarySearch(names, "Harry");
        Console.WriteLine($"\nIndex of 'Harry': {index}"); // Output: 1 (in the sorted list)
    }
}