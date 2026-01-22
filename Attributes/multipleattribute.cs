
using System;
class multipleattribute
{
    [Obsolete] //a1
    [CLSCompliant(true)] //a2
    static void Test()
    {
        Console.WriteLine("Test");
    }
    static void Main()
    {
        Test();
    }
}
