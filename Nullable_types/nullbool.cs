using System;
class Nullbool
{
    static void Main()
    {
        bool? b = null; //bool? supports three values true,false & null
        if (b == true)
            Console.WriteLine("true");
        else if (b == false)
            Console.WriteLine("false");
        else
            Console.WriteLine("null");
    }
}