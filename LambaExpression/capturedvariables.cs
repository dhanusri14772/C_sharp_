using System;
class Capturedvariable
{
    static void Main()
    {
        int factor = 10; //outer variable
        Func<int,int>multiply = x => x * factor; // outer variable "factor" is been used in the lambda here , thus it captures the reference and not the value "10" 
        factor = 20; 
        Console.WriteLine(multiply(465));
    }
}