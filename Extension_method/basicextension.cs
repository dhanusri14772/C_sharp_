using System;
static class stringextensions
{
    public static string shout(this string s) //creating a method "shout" on the method "string"
    {
        return s.ToUpper() + "<3 !!!"; //addding methods to the existing string without modifying it 
    }
}
class Extension
{
    static void Main()
    {
        string fantasy = "she is a fantasy ..ohhoo";
        Console.WriteLine(fantasy.shout());
    }
}