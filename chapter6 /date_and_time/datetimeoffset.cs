using System;
class Datetimeoffset
{
    static void Main()
    {
        DateTimeOffset dto =
            new DateTimeOffset(2024, 1, 27, 10, 0, 0, TimeSpan.FromHours(+5));
        Console.WriteLine(dto);
        Console.WriteLine(dto.UtcDateTime); //converts stored time to utc
        Console.WriteLine(dto.LocalDateTime); //converts stored time to systems local zone
    }
}
