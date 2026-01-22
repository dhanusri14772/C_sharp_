using System;
using System.Linq;
class Human
{
    public string name { get; set; }
    public string city { get; set; }
}
class Linqanonymous
{
    static void Main()
    {
        var Humans = new[] //creating array of humans
        {
            new Human { name = "dhanusri", city = "London" },
            new Human { name = "prathiksha", city = "Paris" }
        };
        var query = Humans.Select(c => new { c.name, c.city });

        foreach (var x in query)
            Console.WriteLine($"{x.name} - {x.city}");
    }
}
