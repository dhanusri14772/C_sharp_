using System;
class Animal
{
    protected string Type = "Animal";
}
class Dog : Animal
{
    public void Show()
    {
        Console.WriteLine(Type); 
    }
}
class Program
{
    static void Main()
    {
        Dog d = new Dog();
        d.Show();
    }
}
