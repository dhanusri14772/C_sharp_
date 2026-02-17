using System;
using System.Threading;
class Program
{
    static void Main()
    {
        LongRunningOperation();
        Console.WriteLine("Main thread is finally free!");
    }
    static void LongRunningOperation()
    {
        Console.WriteLine("Starting a 3-second task...");
        Thread.Sleep(3000); 
        Console.WriteLine("Task complete.");
    }
}