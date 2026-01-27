using System;
using System.Collections.Generic;
using System.IO;
class Base_class_library
{
    static void Main()
    {
        List<int> nums = new List<int> {1,2,3 , 4,57,55,85,89,847,25,14,23,55,12,55,669,58,85,858};
        File.WriteAllText("data.txt","Hello bcl");
        Console.WriteLine(nums.Count);
    }
}