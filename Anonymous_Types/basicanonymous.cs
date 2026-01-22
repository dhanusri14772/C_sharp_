using System;
class Anonymous
{
    static void Main()
    {
        var dude = new {name = "dhanusri", age = "21", height = "160"}; //anonymous types with string,int are given where the compiler generates a inner class of defining those var types 
        Console.WriteLine(dude.name);
        Console.WriteLine(dude.age);
        Console.WriteLine(dude.height);
    }
}