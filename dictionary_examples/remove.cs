using System;
using System.Collections;
class Iterate
{
   public static void Main()
   {
    Dictionary<string,string> student = new Dictionary<string,string>();
    student.Add("name" , "hayansh");
    student.Add("age" , "21");
    student.Add("year" , "2004");
    student.Add("department" , "cse");

    Console.WriteLine("original dictionary:");
    foreach (KeyValuePair<string,string> items in student )
    {
        Console.WriteLine("{0} : {1}" , items.Key , items.Value);
    }
    student.Remove("age");
    Console.WriteLine("Modified Dictionary:");

    foreach(KeyValuePair<string,string> items in student)
    {
    Console.WriteLine("{0} : {1}" , items.Key , items.Value);
   }
   }
}