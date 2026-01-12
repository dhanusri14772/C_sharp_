using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.IO;

class Filetypeanalyzer
{
    static void Main()
    {
        var psi = new ProcessStartInfo
        {
          FileName = "cmd.exe",
          Arguments = "/c dir /b",
          WorkingDirectory = @"c:\Users\Dhanusri.T\Downloads",
          RedirectStandardOutput = true ,
          UseShellExecute = false,
    };

   var process = Process.Start(psi);
        var counts = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

        while (!process.StandardOutput.EndOfStream)
        {
            string line = process.StandardOutput.ReadLine();

            if (Directory.Exists(line)) continue;

            string ext = Path.GetExtension(line);
            if (string.IsNullOrEmpty(ext)) ext = "NO_EXT";

            if (counts.ContainsKey(ext))
                counts[ext]++;
            else
                counts[ext] = 1;
        }

        Console.WriteLine("File type summary:\n");
        foreach (var item in counts)
            Console.WriteLine($"{item.Key} → {item.Value}");
    }
}