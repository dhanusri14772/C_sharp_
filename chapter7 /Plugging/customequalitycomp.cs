using System;
using System.Collections.Generic;
public class Customer
{
    public string LastName;
    public string FirstName;
    public Customer(string last, string first)
    {
        LastName = last;
        FirstName = first;
    }
}
// Custom comparer that inherits from EqualityComparer<T>
public class LastFirstEqComparer : EqualityComparer<Customer>
{
    // 1. Define what makes two customers "equal"
    public override bool Equals(Customer x, Customer y)
    {
        if (x == null || y == null) return x == y;
        return x.LastName == y.LastName && x.FirstName == y.FirstName;
    }
    // 2. Define how to get a hash code based on those same fields
    public override int GetHashCode(Customer obj)
    {
        // A simple way to combine hash codes from the book
        return (obj.LastName + ";" + obj.FirstName).GetHashCode();
    }
}
public class Customequalitycomparer
{
    public static void Main()
    {
        Customer c1 = new Customer("Bloggs", "Joe");
        Customer c2 = new Customer("Bloggs", "Joe");

        var d1 = new Dictionary<Customer, string>();
        d1[c1] = "Joe";
        Console.WriteLine($"Default Dictionary contains c2: {d1.ContainsKey(c2)}"); 
        var eqComparer = new LastFirstEqComparer();
        var d2 = new Dictionary<Customer, string>(eqComparer);
        d2[c1] = "Joe";
        Console.WriteLine($"Custom Dictionary contains c2: {d2.ContainsKey(c2)}");  
    }
}