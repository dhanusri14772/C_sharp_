using System;
class Pro
{
    static void Main()
    {
        string s1 = "hi"; //this string is immutable 
        string s2 = s1; //created new string s2
        s1 = s1 + "!";
        Console.WriteLine(s1); 
        Console.WriteLine(s2);
    }
}
