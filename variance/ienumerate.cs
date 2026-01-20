using System;
using System.Collections.Generic;
class Ienumerate
{
    static void Main()
    {
        List<string> list = new List<string> {"A" , "B", "C"};
        IEnumerable<string> seq = list; //enumerate here created just views the "list" which is its only property 
        foreach (var x in seq)
           Console.WriteLine(x);
    }
}