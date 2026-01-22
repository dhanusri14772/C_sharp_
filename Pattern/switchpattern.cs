using System;
class Switch
{
    static void Main()
    {
        int n = 2;
        string text = n switch //switch exp returns values
        {
            1 => "first",
            2 => "second",
            _ => "participated"
        };
        Console.WriteLine(text);
    }
}
