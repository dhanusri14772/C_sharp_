using System;
class Namepositional
{
    [Obsolete("Use NewMethod instead", IsError = false)] //attribute initialization with positional parameter "use newmethod instead"
    static void OldMethod()
    {
        Console.WriteLine("Old method");
    }
    static void Main()
    {
        OldMethod();
    }
}
