using System;
using System.Runtime.CompilerServices;
[assembly: CLSCompliant(true)] //assemblies are defined outside the class
class Person
{
    [field: NonSerialized] //autoproperty normally hides backing field
    public int Age { get; set; }
}
class Assemblies
{
    static void Main()
    {
        Person p = new Person { Age = 30 };
        Console.WriteLine(p.Age);
    }
}
