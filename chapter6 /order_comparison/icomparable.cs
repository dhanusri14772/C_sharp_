using System;
class Person : IComparable<Person>
{
    public string Name;
    public int Age;

    public int CompareTo(Person other)
    {
        return Age.CompareTo(other.Age);
    }
}
class Program
{
    static void Main()
    {
        Person[] people =
        {
            new Person { Name = "A", Age = 30 },
            new Person { Name = "B", Age = 20 },
            new Person { Name = "C", Age = 40 }
        };
        Array.Sort(people);
        foreach (var p in people)
            Console.WriteLine(p.Age);
    }
}
