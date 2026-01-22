using System;
class Dynamic
{
    static void Main()
    {

        dynamic d = "hello,bonjour . hope u are doing well "; //variable type here is dynamic which lets the string to be checked while running
        Console.WriteLine(d.ToUpper()); //checks this method at runtime and binds the method
    }
}
