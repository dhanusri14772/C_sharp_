using System;
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;

class LsFileOrganizerPSI
{
    static void Main()
    {
        string desktopPath = @"C:\Users\Dhanusri.T\Desktop";
        string logDir = Path.Combine(desktopPath, "Desktop_Logs_PSI");

        Directory.CreateDirectory(logDir);

        var logs = new Dictionary<string, List<string>>
        {
            { "pdfs.log", new List<string>() },
            { "images.log", new List<string>() },
            { "data.log", new List<string>() },
            { "links.log", new List<string>() },
            { "folders.log", new List<string>() },
            { "others.log", new List<string>() }
        };

        ProcessStartInfo psi = new ProcessStartInfo
        {
            FileName = "cmd.exe",
            Arguments = $"/c dir \"{desktopPath}\"",
            RedirectStandardOutput = true,
            UseShellExecute = false,
            CreateNoWindow = true
        };

        using Process? process = Process.Start(psi);
        if (process == null)
        {
            Console.WriteLine("Failed to start process.");
            return;
        }

        while (!process.StandardOutput.EndOfStream)
        {
            string? line = process.StandardOutput.ReadLine();
            if (string.IsNullOrWhiteSpace(line))
                continue;

            if (line.StartsWith(" Volume") ||
                line.StartsWith(" Directory") ||
                line.Contains("File(s)") ||
                line.Contains("Dir(s)"))
                continue;
            string[] parts = line.Split(
                new[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries
            );
            if (line.Contains("<DIR>"))
            {
                string folderName = parts[^1];
                logs["folders.log"].Add(folderName);
            }
            else if (parts.Length >= 4)
            {
                string fileName = parts[^1];
                string ext = Path.GetExtension(fileName).ToLower();

                if (ext == ".pdf")
                    logs["pdfs.log"].Add(fileName);
                else if (ext == ".jpg" || ext == ".png")
                    logs["images.log"].Add(fileName);
                else if (ext == ".csv" || ext == ".xls" || ext == ".xlsx")
                    logs["data.log"].Add(fileName);
                else if (ext == ".lnk")
                    logs["links.log"].Add(fileName);
                else
                    logs["others.log"].Add(fileName);
            }
        }

        process.WaitForExit();

        foreach (var log in logs)
        {
            File.WriteAllLines(Path.Combine(logDir, log.Key), log.Value);
        }

        Console.WriteLine("Desktop organized into logs using PSI successfully!");
    }
}
