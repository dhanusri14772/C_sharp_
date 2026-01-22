using System;
class Propertynameinference
{
    static void Main()
    {
        string name = "dhanusri thirunavukarasu";
        var Human = new{name}; //property name assigned as name , field inside anonymous object is a property name
        Console.WriteLine(Human.name);
    }
}