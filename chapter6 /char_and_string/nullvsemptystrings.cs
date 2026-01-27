using System;
class Nulltype
{
    static void Main()
    {
        string empty = "";
        string alsoEmpty = string.Empty;
        string? nothing = null;
        Console.WriteLine(empty.Length);          // gives the length of string
        Console.WriteLine(alsoEmpty.Length);      
        Console.WriteLine(empty == "");           // checks if its T/F
        Console.WriteLine(empty == string.Empty); 
        Console.WriteLine(nothing == null);       
        Console.WriteLine(string.IsNullOrEmpty(empty));   
        Console.WriteLine(string.IsNullOrEmpty(nothing)); 
    }
}
