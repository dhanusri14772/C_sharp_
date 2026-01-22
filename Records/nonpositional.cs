using System;
record Person
{
    public string Name { get; init; }
    public int Age { get; init; }
}
class Program
{
    static void Main()
    {
        var p = new Person { Name = "dhanusri", Age = 21 };
        Console.WriteLine(p.Name);
        Console.WriteLine(p.Age);
    }
}
