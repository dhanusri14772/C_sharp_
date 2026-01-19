using System;
enum Bordersidebyte : byte
{
    left = 1, right = 2, top = 3 , bottom = 4
}
class Dhanu
{
    static void underlyingtypes()
    {
        Bordersidebyte side = Bordersidebyte.top;
        Console.WriteLine((byte)side);
    }
    static void Main()
    {
        underlyingtypes();
    }
}