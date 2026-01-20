using System;
class Base
{
    private protected int Y = 20;
}
class Child : Base
{
    public void Show()
    {
        Console.WriteLine(Y); //accesed in the same project and same class
    }
}
class CSharp
{
    static void Main()
    {
        Child c = new Child();
        c.Show();
    }
}
