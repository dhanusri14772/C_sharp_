using System;
class Action
{
    static void Main()
    {
        Action<string> a = msg => Console.WriteLine(msg);
        a("hey youuuu <3");
    }
}