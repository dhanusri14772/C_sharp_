using System;
using System.Collections.Generic;
class Deferredexecution
{
    static IEnumerable<int> Test()
    {
        Console.WriteLine("Start");
        yield return 1;
        Console.WriteLine("Middle");
        yield return 2;
        Console.WriteLine("oops End");
    }
    static void Main()
    {
        var seq = Test();   //here nothing runs yet, where the execution is deferred until enumeration begins 
    }
}
