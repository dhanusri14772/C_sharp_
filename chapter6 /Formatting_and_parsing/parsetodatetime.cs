using System;
class Parsestringtodatetime
{
    static void Main()
    {
        string text = "27/01/2024";
        DateTime dt = DateTime.Parse(text);
        Console.WriteLine(dt);
    }
}
