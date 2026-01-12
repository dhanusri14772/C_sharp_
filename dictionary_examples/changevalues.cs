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
    
    Console.WriteLine("value of model before changing:" );
    Console.WriteLine(car["model"]);
    Console.WriteLine(car["year"]);
    car["model"] = "maruti" ; //changing values
    car["year"]  = "2026" ;  //changing values
    Console.WriteLine("value after changing of the values" );
    Console.WriteLine(car["model"]);
    Console.WriteLine(car["year"]);
}
}