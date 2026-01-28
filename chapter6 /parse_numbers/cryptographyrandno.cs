using System;
using System.Security.Cryptography;
class CRypto
{
    static void Main()
    {
        var rand = RandomNumberGenerator.Create();
        byte[] bytes = new byte[4];
        rand.GetBytes(bytes);
        int value = BitConverter.ToInt32(bytes, 0);
        Console.WriteLine(value);
    }
}