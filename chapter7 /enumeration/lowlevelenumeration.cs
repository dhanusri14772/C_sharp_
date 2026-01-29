using System;
using System.Collections;
public class Lowlevelenumerate
{
    public static void Main()
    {
        string s = "Hello makaleeee, welcome to my youtube channel";
        IEnumerator rator = s.GetEnumerator();
        while (rator.MoveNext())
        {
            char c = (char)rator.Current;
            Console.Write(c + ".");
        }
    }
}