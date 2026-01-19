using System;
class Parent
{
    public Parent()
    {
        Console.WriteLine("Parent constructor");
    }
}
class Child : Parent
{
    public Child() : base()
    {
        Console.WriteLine("Child constructor");
    }
}
class Program
{
    static void Main()
    {
        Child c = new Child();
    }
}
