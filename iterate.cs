using System;
using System.Collections;
class Iterate
{
   public static void Main()
   {
   
    Dictionary<string,string> car = new Dictionary<string,string>();
    car.Add("model" , "hyundai");
    car.Add("price" , "15L");
    car.Add("year" , "2024");
    car.Add("version" , "version 7");
    foreach (KeyValuePair<string,string> items in car )
    {
        Console.WriteLine("{0} : {1}" , items.Key , items.Value);
    }
}
}