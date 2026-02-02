using System;
using System.Linq;
public class Join
{
    public static void Main()
    {
        int[] numbers = {1,2,3,4,5};
        string[] words = {"one","two","three"};
        var query = numbers.Join(words, n => n, w = w.Length, (n,w)=> n + "is" + w);
        foreach (string s in query) Console.WriteLine(s);
    }
}