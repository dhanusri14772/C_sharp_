using System;
abstract class Animal
{
    public abstract void speak();
    public void sleep()
    {
        Console.WriteLine("sleeping");
    }
}
class Dog : Animal
{
    public override void speak()
    {
        Console.WriteLine("barks"); //child class in the interface must execute the abstract class's method 
    }
}
class abstractin
{
    static void Main()
    {
        Dog d = new Dog();
        d.speak();
        d.sleep();
    }
}
