using System;
class Animal
{
    public void Speak()
    {
        Console.WriteLine("Animal speaks");
    }
}
class Dog : Animal
{
}
class Program
{
    static void Main()
    {
        Animal a = new Dog(); // upcasting
        a.Speak();
    }
}
