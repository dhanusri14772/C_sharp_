using System;
static class Compilertranslatesextensioncalls
{
  public static void print(this string s)
    {
        Console.WriteLine(s);
    }    
}
class Bro
{
    static void Main()
    {
        string i = "csharp is sharping my knowledge!";
        i.print(); //this is the direct extension call
        Compilertranslatesextensioncalls.print(i); //this is the actual call
    }
}