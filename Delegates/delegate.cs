using System;
delegate void Delegate();
class Create
{
    static void Hello()
    {
        Console.WriteLine("Helloo bonjour");
    }
    static void Main()
    {
        Delegate d = Hello; //stores the method "Delegate " in a variable d 
        d(); //calls the method delegate 
    }
}