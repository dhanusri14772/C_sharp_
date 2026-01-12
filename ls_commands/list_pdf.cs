using System;
using System.Diagnostics;

class Listbypdf
{
    static void Main()
    {
        var psi = new ProcessStartInfo
          {
            FileName = "cmd.exe",
            Arguments = "/c dir *.pdf /o:-d", // *.pdf , *.jpg , *.csv, *.png - these can also be listed .
            WorkingDirectory = @"C:\Users\Dhanusri.T\Downloads",
            RedirectStandardOutput = true,
            UseShellExecute = false
          };
        var process = Process.Start(psi);
        Console.WriteLine(process.StandardOutput.ReadToEnd());
    }
}