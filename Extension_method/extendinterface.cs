using System;
using System.Collections.Generic;
static class Enumerableextensions
{
    public static void print(this IEnumerable<object> nums)
    {
        foreach (var n in nums)
            Console.WriteLine(n);
    }
}
class Interface
{
    static void Main()
    {
        List<object> list = new List<object> { 1, 2, 3, "gossips" , "joy","friend in need", "friend in deed" };
        list.print();
    }
}
