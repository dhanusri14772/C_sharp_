using System;
class Door
{
    public event EventHandler Opened;
    public void Open()
    {
        Opened?.Invoke(this, EventArgs.Empty);
    }
}
class Program
{
    static void Main()
    {
        Door d = new Door();
        d.Opened += (s, e) => Console.WriteLine("Door opened");
        d.Open();
    }
}
