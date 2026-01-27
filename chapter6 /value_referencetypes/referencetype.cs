using System;
class Referencetype
{
    public int age;
}
class Pro
{
    static void Main()
    {
        Referencetype p1 = new Referencetype();
        p1.age = 29;
        Referencetype p2 = p1; //both p1&p2shares same object
        p2.age = 40;  //both p1&p2 gets updated to 40.
        Console.WriteLine(p1.age);
        Console.WriteLine(p2.age);
    }
}