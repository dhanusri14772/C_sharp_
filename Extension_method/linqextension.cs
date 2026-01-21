using System;
using System.Linq;
class Extensionlinq
{
    static void Main()
    {
        int[] nums = { 1250, 2784, 3251, 4415 , 1455,7844 , 9856, 2541,6354,9865,2417,32654,2154};
        var even = nums.Where(n => n % 2 == 0); 
        foreach (var n in even)
            Console.WriteLine(n);
    }
}
