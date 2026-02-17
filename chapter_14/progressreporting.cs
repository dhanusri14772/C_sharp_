using System;
using System.Threading.Tasks;
class Progressreport
{
    static async Task Main()
    {
        var progressreporter = new Progress<int>(percent =>
        {
            Console.WriteLine($"progress: {percent}%");
        });
        Console.WriteLine("starting heavy work");
        await DoWorkAsync(progressreporter);
        Console.WriteLine("work completed");
    }
static async Task DoWorkAsync(IProgress<int> Progress)
    {
        for (int i = 1; i <= 10; i++)
        {
            await Task.Delay(500);
            Progress.Report(i*10);
        }
    }
}