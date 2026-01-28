using System;
using System.Globalization; //gives culture.info
class Parseexact
{
    static void Main()
    {
        string text = "2024-01-27";
        DateTime dt = DateTime.ParseExact(
            text,                                                
            "yyyy-MM-dd",
            CultureInfo.InvariantCulture
        ); //parseexact parses only if the format matches 
        Console.WriteLine(dt);
    }
}
