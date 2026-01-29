using System;
using System.Collections;
public class MyCollection : IEnumerable
{
    int[] data = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    public IEnumerator GetEnumerator()
    {
        foreach (int i in data)
            yield return i;
    }
}
public class Program
{
    public static void Main()
    {
        MyCollection collection = new MyCollection();
        foreach (int i in collection)
        {
            Console.WriteLine(i);
        }
    }
}