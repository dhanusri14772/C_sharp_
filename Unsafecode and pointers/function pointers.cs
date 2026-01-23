using System;
class Program
{
    unsafe static int Add(int a, int b) => a + b;
    unsafe static void Main()
    {
        delegate*<int, int, int> ptr = &Add;
        int result = ptr(3, 4);
        Console.WriteLine(result);
    }
}
