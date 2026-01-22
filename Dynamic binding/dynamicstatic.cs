using System;
class Dynamicstatic
{
    static void Main()
    {
        dynamic d = 10; //dynamic
        int x = 5; //static
        var result = d + x; //this contains a dynamic variable thus the entire exp becomes dynamic
        Console.WriteLine(result);
    }
}
