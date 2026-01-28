using System;
class Program
{
    static void Main()
    {
        Guid g = Guid.NewGuid(); //creates unique identifier
        Console.WriteLine(g.ToString());
    }
}