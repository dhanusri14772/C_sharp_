using System;
using System.Linq;
class Linq
{
    static void Main()
    {
        string[] names = {"tom","cherry","meee","haaris","numeel"};
        var result = names.Where(n => n.Length >= 4); //predicate lambda where linq claas it for each element .

    foreach (var n in result)
        Console.WriteLine(n);
    }
}