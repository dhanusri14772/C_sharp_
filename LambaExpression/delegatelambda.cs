using System;
class Delegate
{
    static void Main()
    {
        Action greet = () => Console.WriteLine("Hello , bonjour");
        greet() ;
    }
}