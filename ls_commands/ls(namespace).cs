using System;
using System.IO;

class Program
{
    static void Main()
    {
        string desktopPath = @"C:\Users\Dhanusri.T\Desktop";
    

        Console.WriteLine("Folders:");
        foreach (string dir in Directory.GetDirectories(desktopPath))
        {
            Console.WriteLine(Path.GetFileName(dir));
        }

        Console.WriteLine("\nFiles:");
        foreach (string file in Directory.GetFiles(desktopPath))
        {
            Console.WriteLine(Path.GetFileName(file));
        }
    }
}
