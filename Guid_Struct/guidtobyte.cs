using System;
class Guidarray
{
    static void Main()
    {
        Guid g = Guid.NewGuid();
        byte[] bytes = g.ToByteArray(); //converts to array
        Console.WriteLine(bytes.Length);
    }
}
