using System;
class Animal {}
class dog : Animal {}
class Reference
{
    static void Main()
    {
        Animal a = new dog();
        dog d = (dog)a; //referencing dog , generally its also a downcast

        Console.WriteLine("cast done");
    }
}