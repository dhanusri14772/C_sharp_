using System;
class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating");
    }
}
class Dog : Animal
{
}
class Program
{
    static void Main()
    {
        Dog d = new Dog();
        d.Eat();
    }
}
