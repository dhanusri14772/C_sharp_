using System;
class Whenguard
{
    static void Main()
    {
        object x = 15;
        string result = x switch
        {
            int i when i > 10 => "big number", //type check and extra "when" condition to patterns 
            int i => "small number",
            _ => "not number"
        };
        Console.WriteLine(result);
    }
}
