using System;
class Convdtdto
{
    static void Main()
    {
        DateTime dt = new DateTime(2000, 2, 3, 10, 0, 0, DateTimeKind.Local);
        DateTimeOffset dto = dt;   // implicit conversion
        Console.WriteLine(dt);
        Console.WriteLine(dto);
    }
}
