using System;

class Person
{
    public Person() { }
}

class Factory<T> where T : new()
{
    public T Create()
    {
        return new T();
    }
}

class Program
{
    static void Main()
    {
        Factory<Person> f = new Factory<Person>();
        Person p = f.Create();
        Console.WriteLine("Person created");
    }
}
