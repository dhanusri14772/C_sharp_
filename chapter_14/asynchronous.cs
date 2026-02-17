using System;
using System.Threading.Tasks;
class Program
{
    static async Task Main()
    {
        Console.WriteLine("Starting the async task...");
        await DoSomethingAsync();
        Console.WriteLine("Done!");
    }
    static async Task DoSomethingAsync()
    {
        Console.WriteLine("Task started. Waiting 3 seconds...");
        await Task.Delay(3000); 
        Console.WriteLine("Task finished.");
    }
}