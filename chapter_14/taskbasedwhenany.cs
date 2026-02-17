using System;
using System.Threading.Tasks;
class Taskbasedwhenany
{
    static async Task Main()
    {
        Console.WriteLine("The race is starting...");
        Task<string> taskA = DownloadFakeDataAsync("Server A", 3000);
        Task<string> taskB = DownloadFakeDataAsync("Server B", 1000);
        Task winnerTask = await Task.WhenAny(taskA, taskB);
        if (winnerTask == taskB)
        {
            Console.WriteLine("Server B won the race!");
        }
        string result = await (Task<string>)winnerTask;
        Console.WriteLine($"Winner Result: {result}");
    }
    static async Task<string> DownloadFakeDataAsync(string name, int ms)
    {
        await Task.Delay(ms);
        return $"Data from {name}";
    }
}