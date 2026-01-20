using System;
interface Ifly
{
    void fly();
}
interface Iswim
{
    void swim();
}
class Duck : Ifly, Iswim
{
    public void fly() => Console.WriteLine("Duck is flying");
    public void swim() => Console.WriteLine("Duck is swimming");
}
class multiple_Interface_inheritance
{
    static void Main()
    {
        Duck d = new Duck();
        d.fly();
        d.swim();
    }
}