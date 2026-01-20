using System;
class Boxunbox
{
    static void Main()
    {
        int x = 14;
        object o = x; //boxing into object "o"
        int y = (int)o; // unboxing it explicitly
        Console.WriteLine(y);
    }
}