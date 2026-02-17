using System;
using System.Threading;
using System.Threading.Tasks;
class Cancel
{
    static async Task Main()
    {
        var cancelSource = new CancellationTokenSource();
        Console.WriteLine("Starting a task that takes 5 seconds...");
        Task workTask = DoWorkAsync(cancelSource.Token);
        await Task.Delay(2000);
        Console.WriteLine("Too slow! Requesting cancellation...");
        cancelSource.Cancel(); 
        try 
        {
            await workTask;
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("The task was successfully cancelled.");
        }
    }
    static async Task DoWorkAsync(CancellationToken token)
    {
        for (int i = 0; i < 5; i++)
        {
            token.ThrowIfCancellationRequested(); 
            Console.WriteLine($"  Work in progress... {i+1}s");
            await Task.Delay(1000); //delays onesecond 
        }
        Console.WriteLine("Work completed normally!");
    }
}