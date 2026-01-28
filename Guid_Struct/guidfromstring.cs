using System;
class guidstring
{
    static void Main()
    {
        Guid g1 = new Guid("{0d57629c-7d6e-4847-97cb-9e2fc25083fe}");
        Guid g2 = new Guid("0d57629c7d6e484797cb9e2fc25083fe"); //doesnt have "-"
        Console.WriteLine(g1 == g2); //both have 16 same bytes 
    }
}