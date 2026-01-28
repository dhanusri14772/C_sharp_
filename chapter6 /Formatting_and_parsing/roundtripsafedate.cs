using System;
class Roundtripsafe
{
    static void Main()
    {
        DateTime now = DateTime.Now;
        string safe = now.ToString("o"); //iso 8602 format , includes milliseconds and it is culture independent
        DateTime parsed = DateTime.Parse(safe);
        Console.WriteLine(now);
        Console.WriteLine(safe);
        Console.WriteLine(parsed);
    }
}
