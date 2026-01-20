using System;
class Gettypeof
{
    static void Main()
    {
        string D = "csharp is something that is essential for the integration part";
        Console.WriteLine(D.GetType().Name); //gets the type of string that we defined 
        Console.WriteLine(typeof(string).Name); //says the type of string used to create D""
        Console.WriteLine(D.GetType()==typeof(string)); //says if they are true or false
    }
}