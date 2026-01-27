using System;
class Box
{
    public int Value;
}
class Pro
{
 static void Change(Box b)
    {
        b.Value = 10840;
    }

    static void Main()
    {
        Box box = new Box(); //"box here only takes the refernce from "Box" not the value of Box"
        box.Value = 15150; 

        Change(box);

        Console.WriteLine(box.Value);
    }
}
    
