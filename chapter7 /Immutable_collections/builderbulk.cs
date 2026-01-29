using System;
using System.Collections.Immutable;
public class BUilder
{
    public static void Main()
    {
        ImmutableList<int> emptyList = ImmutableList.Create<int>();
        var builder = emptyList.ToBuilder();
        for (int i = 0; i < 100; i++)
            builder.Add(i);
        ImmutableList<int> finalresult = builder.ToImmutable();
        Console.WriteLine($"final immutable list has {finalresult.Count} items.");
        foreach (var i in builder) Console.WriteLine(i);
    }
}