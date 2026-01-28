using System;
class Dateonly
{
    static void Main()
    {
        DateOnly birthday = new DateOnly(2002, 5, 14);
        Console.WriteLine(birthday);
        Console.WriteLine(birthday.Year);
        Console.WriteLine(birthday.Month);
        Console.WriteLine(birthday.Day);
    }
}