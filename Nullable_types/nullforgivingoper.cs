using System;
class Nullforgive
{
    static void Main()
    {
        string? text = "Hello , bonjour";
        Console.WriteLine(text!.Length); //"!" ensures that null is not here in this 
    }
}