using System;
class Typepattern
{
    static void Main()
    {
        object x = "hello , bonjour!";
        if (x is string s)
            Console.WriteLine(s.Length);
    }
}
