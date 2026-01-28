using System;
class guidArray
{
    static void Main()
    {
        byte[] bytes = new byte[16];
        for (int i = 0; i < 16; i++)
            bytes[i] = (byte)i;
        Guid g = new Guid(bytes);
        Console.WriteLine(g);
    }
}