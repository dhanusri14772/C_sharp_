using System;
using System.Collections.Generic;
public class Queueandstack
{
    public static void Main()
    {
        var s = new Queue<int>();
        s.Enqueue(100);
        s.Enqueue(300);
        Console.WriteLine(s.Dequeue());
       
        var t = new Stack<int>();
        t.Push(90);
        t.Push(675);
        Console.WriteLine(t.Pop());
    
    }   
}