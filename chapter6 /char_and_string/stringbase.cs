using System;
class Stringbase
{
    static void Main()
    {
        string s1 = "Hello";
        string s2 = "First Line\r\nSecond Line"; // here \r\n refers to new line
        string s3 = @"C:\Temp\Files\Test.txt"; //verbatim string
        Console.WriteLine(s1);
        Console.WriteLine(s2);
        Console.WriteLine(s3);
        Console.WriteLine(new string('*', 10));
        char[] letters = "Hello".ToCharArray(); //string to char letters
        string s4 = new string(letters); //char to string 
        Console.WriteLine(s4);
    }
}
