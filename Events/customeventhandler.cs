using System;
class TempEventArgs : EventArgs
{
    public int Temperature { get; set; }
}
class Sensor
{
    public event EventHandler<TempEventArgs> Overheat;
    public void Check(int temp)
    {
        if (temp > 100)
            Overheat?.Invoke(this, new TempEventArgs { Temperature = temp });
    }
}
class Temper
{
    static void Main()
    {
        Sensor s = new Sensor();
        s.Overheat += (sender, e) =>
            Console.WriteLine("Temp = " + e.Temperature);

        s.Check(120);
    }
}
