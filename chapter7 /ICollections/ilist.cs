using System;
using System.Collections.Generic;
public class Ilist
{
    public static void Main()
    {
        IList<string> list = new List<string> {"Alpha","bravo board","delta"};
        Console.WriteLine($"ITEM AT INDEX 1:{list[1]}");
        list.Insert(2, "charlie");
        Console.WriteLine($"new item at index 2 :{list[2]}");
        Console.WriteLine($"index of delta : {list.IndexOf("delta")}");
        list.RemoveAt(0);
        Console.WriteLine($"new first item: {list[0]}");
    }
}