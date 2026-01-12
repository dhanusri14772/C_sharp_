using System;
using System.Collections;
class Dict
{
    public static void Main()
    {
        Dictionary<int , string> country  = new Dictionary<int , string>(); //creating a dictionary 
        country.Add(5 , "brazil");
        country.Add(6, "china");
        country.Add(4, "united states");

        Console.WriteLine("value having key 4:" + country[4]);
    }
}