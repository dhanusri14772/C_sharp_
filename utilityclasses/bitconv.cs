using System;

class Program
{
    static void Main()
    {
        int number = 12345;

        byte[] bytes = BitConverter.GetBytes(number);

        int rebuilt = BitConverter.ToInt32(bytes, 0);

        Console.WriteLine(rebuilt);
    }
}
