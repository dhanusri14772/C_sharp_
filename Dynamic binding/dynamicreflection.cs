using System;
class Dynamic
{
    public string Name => "Bob";
}
class Reflection
{
    static void Main()
    {
        object obj = new Dynamic();
        dynamic d = obj;
        Console.WriteLine(d.Name);
    }
}
