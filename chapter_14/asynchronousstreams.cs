using System;
using System.Collections.Generic; // Required for IAsyncEnumerable
using System.Threading.Tasks;
class Program
{
    static async Task Main()
    {
        Console.WriteLine("Connecting to sensor stream...");
        await foreach (int reading in GetSensorDataAsync())
        {
            Console.WriteLine($"[Main] Received reading: {reading} at {DateTime.Now.ToLongTimeString()}");
        }
        Console.WriteLine("Stream ended.");
    }
    static async IAsyncEnumerable<int> GetSensorDataAsync()
    {
        for (int i = 1; i <= 5; i++)
        {
            
            await Task.Delay(1000); 
            yield return i; 
        }
    }
}