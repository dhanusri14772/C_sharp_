using System;
class Structuralequality
{
    static void Main()
    {
        var a = new {x = 1 , y = 2};
        var b = new {x = 1 , y = 2}; //equals work only if the property names and all the values to it are same.
        Console.WriteLine(a.Equals(b)); //equality = compiler creates same anonymous types
    }
}