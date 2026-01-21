using System;
class Finally
{
    static void Main()
    {  
        try
        {
        Console.WriteLine("trying");
        int x = 0 ;
        int z = 1000/x;
        }
        catch
        {
            Console.WriteLine("caught");
        }
        finally
        {
            Console.WriteLine("runs irrespective of the exception blocks");
        }
}
}