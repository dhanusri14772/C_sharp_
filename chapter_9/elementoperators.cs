using System;
using System.Collections.Generic;
using System.Linq;
public class Elementoperator
{
    public static void Main()
    {
        int []numbers = {1,2,3,4,5};
        int first = numbers.First();
        int last = numbers.Last();
        int firstEven = numbers.First(n => n%2 == 0);
        int thirdNumber = numbers.ElementAt(2);
        int[] solo = {99};
        int onlyItem = solo.Single();
        int[] safe = empty.FirstOrDefault();
        Console.WriteLine($"first:{first},last :{last},third :{thirdnumber}");
        Console.WriteLine($"safe result from empty array : {safe}");
    }
}