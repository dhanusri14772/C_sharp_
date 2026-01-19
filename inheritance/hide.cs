using System;
class Animal
{
    public void Speak()
    {
        Console.WriteLine("Animal sound");
    }
}
class Dog : Animal
{
    public new void Speak()
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
        Dog d = new Dog();
        d.Speak();
    }
}
