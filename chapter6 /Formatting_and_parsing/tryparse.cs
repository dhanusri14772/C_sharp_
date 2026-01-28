using System;
class tryparse
{
    static void Main()
    {
        string text = "2024-01-27"; 
        bool success = DateTime.TryParse(text, out DateTime result); //tries to parse and give a output if the string is datetime
        if (success)
            Console.WriteLine(result);
        else
            Console.WriteLine("Invalid date");
    }
}