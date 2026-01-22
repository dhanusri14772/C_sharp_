using System;
class Tuple
{
    static void Main()
    {
        (string, int) Human = ("Bob", 23); //comb string and int as an tuple 
        Console.WriteLine(Human.Item1);
        Console.WriteLine(Human.Item2);
    }
}
