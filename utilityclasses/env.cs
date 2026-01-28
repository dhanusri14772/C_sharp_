using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(Environment.MachineName);
        Console.WriteLine(Environment.OSVersion);
        Console.WriteLine(Environment.CurrentDirectory);

        Console.WriteLine(Environment.GetFolderPath(
            Environment.SpecialFolder.Desktop));
    }
}
