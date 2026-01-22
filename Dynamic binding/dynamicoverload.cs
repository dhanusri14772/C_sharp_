using System;
class Dynamic
{
    public void show(int x) => Console.WriteLine("int");
    public void show(string s) => Console.WriteLine("string");
}
class Brocode
{
    static void Main()
    {
        dynamic d = "helllooooooooooooooo";
        Dynamic t = new Dynamic();
        t.show(d);
    }
}