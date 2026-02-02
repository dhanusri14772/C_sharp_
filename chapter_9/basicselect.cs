using System;
using System.Linq;
public class Selectbase
{
    public static void Main()
    {
    int[] numbers = {1,2,3,4,5,6,7,8,9,01,12,3,445,5,667,7,88,9};
    string[] phrase = {"hello world","linq is cool"};
    var query = numbers.Select(n => "Number:" + n);
    var words = phrase.SelectMany(p => p.Split(' '));
    foreach (var s in query) Console.WriteLine(s);
    foreach (var word in words) Console.WriteLine(word);
}
}