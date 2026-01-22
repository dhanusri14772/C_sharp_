using System;
class Runtimeerror
{
    static void Main()
    {
        dynamic x = 10;
        try
        {
            x.Foo();   // no such method
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.GetType().Name); //says the type of error occured
        }
    }
}
