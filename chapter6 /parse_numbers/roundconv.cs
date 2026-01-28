using System;
class Roundconv
{
    static void Main()
    {
        double d = 3.9;
        int i = Convert.ToInt32(d); //rounds off value instead of truncate 
        Console.WriteLine(i);
    }
}