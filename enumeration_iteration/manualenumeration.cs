using System;
using System.Collections.Generic;
class Manualenumeration
{
    static void Main()
    {
        List<int> nums = new List<int> { 10, 20, 30 };
        IEnumerator<int> e = nums.GetEnumerator(); //gets the object
        while (e.MoveNext()) //moves to next object
        {
            int value = e.Current; //reads current object
            Console.WriteLine(value);
        }
    }
}
