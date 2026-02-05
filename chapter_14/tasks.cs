using System;
using System.Threading.Tasks;
public class Taskse
{
    public static void Main()
    {
        Task.Run(() => Console.WriteLine("FOO"));
        Task<int> task = Task.Run(() => {Console.WriteLine("Foo"); return 3; });
        int result = task.Result;
        Console.WriteLine(result);
    }
}