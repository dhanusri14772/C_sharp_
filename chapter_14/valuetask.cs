using System;
using System.Threading.Tasks;
using System.Collections.Generic;
class Valuetask
{
    static readonly Dictionary<int, string> _cache = new();
    static async Task Main()
    {
        Console.WriteLine("Request 1 (Slow):");
        string result1 = await GetCachedDataAsync(1);
        Console.WriteLine($"Result: {result1}");
        Console.WriteLine("\nRequest 2 (Fast/Optimized):");
        string result2 = await GetCachedDataAsync(1);
        Console.WriteLine($"Result: {result2}");
    }
    static ValueTask<string> GetCachedDataAsync(int id)
    {
        if (_cache.TryGetValue(id, out var cachedValue))
        {
            return new ValueTask<string>(cachedValue);
        }
        return new ValueTask<string>(FetchDataFromSourceAsync(id));
    }
    static async Task<string> FetchDataFromSourceAsync(int id)
    {
        await Task.Delay(1000); // Simulate network
        string data = $"Data for {id}";
        _cache[id] = data;
        return data;
    }
}
