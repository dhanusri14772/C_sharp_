using System;
class Getvalue
{
    static void Main()
    {
        int? x = 24;
        if (x.HasValue) 
           Console.WriteLine(x.Value); //if x has the value ,then it gives the value itself.
    }
}