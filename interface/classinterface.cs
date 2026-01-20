using System;
interface Ianimal
{
    void speak();
}
class Dog: Ianimal
{
    public void speak()
    {
        Console.WriteLine("dog barks");
    }
}
class Interface
{
    static void Main()
    {
        Dog d = new Dog();
        d.speak();
    }
}