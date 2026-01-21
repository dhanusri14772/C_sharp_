using System;
class Nullablemath
{
    static void Main()
    {
        int? x =865;
        
        int? t = null;
        int? v = x+t; //result of v also becomes null 

        Console.WriteLine(v);
    }
}