using System;
class Sortnumber
{
    static void Main()
    {
        int[] nums = { 5, 2, 9, 1 };
        Array.Sort(nums); //calls icomparable , uses ordering rules of int 
        foreach (int n in nums)
            Console.WriteLine(n);
    }
}
