using System;
using System.Collections.Generic;

class Person
{
    public int Id;
    public override bool Equals(object obj)
    {
        return obj is Person p && p.Id == Id;
    }
    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
}
class Program
{
    static void Main()
    {
        var set = new HashSet<Person>();

        set.Add(new Person { Id = 1 });

        Console.WriteLine(set.Contains(new Person { Id = 1 })); // ❌ false!
    }
}
