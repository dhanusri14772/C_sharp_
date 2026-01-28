using System;

enum Color { Red, Green, Blue }

class Program
{
    static void Main()
    {
        string[] names = Enum.GetNames(typeof(Color));

        foreach (string n in names)
            Console.WriteLine(n);

        Color c = (Color)Enum.Parse(typeof(Color), "Green");
        Console.WriteLine(c);
    }
}
