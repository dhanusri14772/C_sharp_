using System;
using System.Numerics;
class Bitoperation
{
    static void Main()
    {
        uint n = 16;
        Console.WriteLine(BitOperations.IsPow2(n));
        Console.WriteLine(BitOperations.Log2(n));
        Console.WriteLine(BitOperations.PopCount(15));
        Console.WriteLine(BitOperations.RoundUpToPowerOf2(17));
    }
}
