using System;
class Hasvlaue
{
    static void Main()
    {
        int? x = null; //initialized as null
        if (!x.HasValue) //checking if it has 
            Console.WriteLine("No value");
        if (x == null)
            Console.WriteLine("Still null");
    }
}
    