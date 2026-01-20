using System;
class Timer
{
    public event Action Tick;
    public void Run()
    {
        Tick?.Invoke();
    }
}
class Program
{
    static void Main()
    {
        Timer t = new Timer();
        Action handler = () => Console.WriteLine("Tick");
        t.Tick += handler; //subscribe"+="
        t.Run(); 
        t.Tick -= handler;  //unsubscribe"-="
        t.Run();
    }
}
