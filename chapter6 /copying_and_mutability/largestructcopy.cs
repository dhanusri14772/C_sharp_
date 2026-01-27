using System;
struct BigStruct
{
    public long A, B, C, D, E, F, G, H;
}
class Largestruct
{
    static void Main()
    {
        BigStruct s1 = new BigStruct();
        BigStruct s2 = s1;
        Console.WriteLine("Copied");
    }
}
