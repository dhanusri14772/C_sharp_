using System;
using System.Globalization;
class Decimalparse
{
    static void Main()
    {
        string pricetext = "1.50";
        double price = double.Parse(pricetext,CultureInfo.InvariantCulture);
        Console.WriteLine(price);
    }
}