using System;
using System.Collections.Generic;
using System.Diagnostics;

class Dictionaryapplauncherpsi
{
    static void Main()
    {
        
        Dictionary<string, string> appMap = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            { "calculator", "calc.exe" },
            { "calc", "calc.exe" },
            { "notepad", "notepad.exe" },                //maps commands to applications 
            { "browser", "https://www.google.com" },
            { "settings", "ms-settings:" },
            { "paint", "mspaint.exe" }
        };

        Console.WriteLine("Enter application name:");
        string? input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Invalid input.");
            return;
        }

        if (!appMap.ContainsKey(input))
        {
            Console.WriteLine("Application not found in launcher.");
            return;
        }

        ProcessStartInfo psi = new ProcessStartInfo
        {
            FileName = appMap[input],
            UseShellExecute = true
        };

        Process.Start(psi);

        Console.WriteLine($"Launching {input}...");
    }
}
