using System;
interface Iprinter
{
    void Print();
}
class Invoice : Iprinter
{
    public void Print() => Console.WriteLine("Invoice printed");
}
class Report : Iprinter
{
    public void Print() => Console.WriteLine("Report printed");
}
class polyinterface
{
    static void Main()
    {
        Iprinter p1 = new Invoice();
        Iprinter p2 = new Report();
        p1.Print();
        p2.Print();
    }
}
