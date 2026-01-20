using System;
class Public
{
    public string Name; // name is public 
}
class Pro
{
    static void Main()
    {
        Public A = new Public();
        A.Name = "DHANU"; //public classes are accessed from another class now 
        Console.WriteLine(A.Name);
    }
}