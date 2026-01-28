using System;
class Customformat
{
    static void Main()
    {
        DateTime dt = DateTime.Now;
        Console.WriteLine(dt.ToString());
        Console.WriteLine(dt.ToString("yyyy-MM-dd"));
        Console.WriteLine(dt.ToString("dd/MM/yyyy"));
        Console.WriteLine(dt.ToString("hh:mm tt"));
    }
}