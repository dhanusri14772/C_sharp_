using System;
class Deconstruct
{
    static void Main()
    {
        var person = (name: "Bob", age: 23); //constructing a tuple with a string and int values
        var (name, age) = person; //deconstructs 
        Console.WriteLine(name);
        Console.WriteLine(age);
    }
}
