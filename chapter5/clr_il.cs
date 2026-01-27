using System;
class Person
{
    public string Name;
}
class Clr_il
{
    static void Main()
    {
        CreateObject();
        GC.Collect();   
        Console.WriteLine("GC executed");
    }
    static void CreateObject()
    {
        Person p = new Person { Name = "A" };
        Console.WriteLine(p.Name);
    }
}
