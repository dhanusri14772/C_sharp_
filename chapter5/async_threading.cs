using System;
using System.Threading.Tasks;
class async_threading
{
    static async Task Main()
    {
        Console.WriteLine("start");
        await DoWorkAsync();
        Console.WriteLine("end");
    }
    static async Task DoWorkAsync()
    {
        await Task.Delay(2000);
        Console.WriteLine("WORK DONE! :)");
    }
}