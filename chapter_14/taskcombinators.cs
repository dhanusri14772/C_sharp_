using System;
using System.Threading.Tasks;
using System.Linq;
class Taskcombinator
{
    static async Task Main()
    {
        Console.WriteLine("Starting multiple downloads...");
        Task<int> task1 = DelayAndReturnAsync(1, 3000); 
        Task<int> task2 = DelayAndReturnAsync(2, 1000); 
        Task<int> task3 = DelayAndReturnAsync(3, 2000); 
        Task<int[]> allTasks = Task.WhenAll(task1, task2, task3);
        int[] results = await allTasks;
        Console.WriteLine("All tasks finished!");
        foreach (var result in results)
        {
            Console.WriteLine($"Task {result} is done.");
        }
    }
    static async Task<int> DelayAndReturnAsync(int val, int ms)
    {
        await Task.Delay(ms);
        return val;
    }
}