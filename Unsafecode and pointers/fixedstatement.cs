using System;

class Program
{
    unsafe static void Main()
    {
        int[] nums = { 1, 2, 3 };
        fixed (int* p = nums) //fixes array in memory
        {
            Console.WriteLine(p[0]);
            Console.WriteLine(p[1]);
        }
    }
}
