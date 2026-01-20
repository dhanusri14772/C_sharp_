using System;
delegate void Mydel();
class multicast
{
    static void A() => Console.WriteLine("A");
    static void B() => Console.WriteLine("B");
    static void Main()
    {
        Mydel d = A;
        d += B; // adds another method 
        d();
    }
}