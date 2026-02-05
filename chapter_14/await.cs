using System;
using System.Threading.Tasks;
public class Pro
{
    public static void Main()
    {
        int result = await GetAnswerToLife();
        Console.WriteLine(result);
    }
    static async Task<int> GetAnswerToLife()
    {
        await Task.Delay(1000);
        return 42;
    }
}