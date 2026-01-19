using System;
class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal sound");
    }
}
class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Dog barks");
    }
}
class Program
{
    static void Main()
    {
        Animal a = new Dog();
        a.Speak();
    }
}
