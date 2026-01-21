using System;
class Human
{
    public string name = "dhanuu";
}
class Combination
{
    static void Main()
    {
        Human? y = null;
        string name = y?.name ?? "oops enter your name"; //combining ? & ?? to make sure that if the null exists then it will be replaced with something else  
        Console.WriteLine(name);
    }
}