using System;
class A
{
    public virtual void Show()
    {
        Console.WriteLine("A Show");
    }
}
class B : A
{
    public sealed override void Show()
    {
        Console.WriteLine("B Show");
    }
}
class Program
{
    static void Main()
    {
        A obj = new B();
        obj.Show();
    }
}
