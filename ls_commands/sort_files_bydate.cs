using System;
using System.Diagnostics;
class Sortbydate
{
    static void Main()
{
    ProcessStartInfo psi = new ProcessStartInfo
{
    FileName = "cmd.exe",
    Arguments = "/c dir / o:d", //o:d is the command for listing the files from oldest to newest & o:-d is the opposite of this . likewise o:-s can be used to detect the larger sized files 
    RedirectStandardOutput = true,
    UseShellExecute = false
};
    Process process = Process.Start(psi);
    Console.WriteLine(process.StandardOutput.ReadToEnd());
}
}