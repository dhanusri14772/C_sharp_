using System;
struct Person
{
    public int Age;
    public Person(int age)
    {
        Age = age; // must assign
    }
}
class Program
{
    static void Main()
    {
        Person p = new Person(25);
        Console.WriteLine(p.Age);
    }
}
