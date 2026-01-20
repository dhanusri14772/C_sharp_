using System;
interface Ifile
{
    void open();
}
class Document : Ifile
{
    void Ifile.open()
    {
        Console.WriteLine("file opened");
    }
}
class Explicit
{
    static void Main()
    {
        Ifile f = new Document();
        f.open(); 
    }
}