using System;
using System.Collections.Immutable;
public class Immutable
{
    public static void Main()
    {
        ImmutableList<string>list1 = ImmutableList.Create<string>("alpha","bravo");
        ImmutableList<string>list2 = list1.Add("charlie");
        ImmutableList<string>list3 = list2.Add("maskara must");
        Console.WriteLine($"list 1 count: {list1.Count}");
        Console.WriteLine($"list 2 count: {list2.Count}");
        Console.WriteLine($"list 3 count:{list3.Count}");
        Console.WriteLine("List 1:");
        foreach (var item in list1) Console.WriteLine(item);
    }
}