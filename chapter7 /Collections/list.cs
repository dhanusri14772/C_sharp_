using System;
using System.Collections.Generic;
public class list
{
    public static void Main()
    {
        var words = new List<string> ();
        words.Add("dhanu sri");
        words.Add("sindhu");
        words.Add("heyyyyyyyyyyyyy");
        words.AddRange(new[] {"singarii","kalyani"}); //adds a range  of strings at the end 
        words.Insert(1, "penne"); //allows to add at specific index
        words.InsertRange(1,new[] {"yaro ival","penguin"}); //a range of values at a specific index are added with "insertrange"
        words.Remove("yaro ival"); //removing a particular string
        words.RemoveAt(1); //removing at particular index
        string[] array = words.ToArray();
        foreach (string s in array) Console.WriteLine(s);
    }
}