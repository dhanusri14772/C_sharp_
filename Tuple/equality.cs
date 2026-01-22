using System;
class TupleEquality
{
    static void Main()
    {
        var a = (1, 2);
        var b = (1, 4);
        Console.WriteLine(a == b); //checking with "=="
    }
}
