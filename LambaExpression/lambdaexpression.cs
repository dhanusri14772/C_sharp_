using System;
using System.Linq.Expressions;
class LambdaExpression
{
    static void Main()
    {
        Expression<Func<int , bool>> exp = x => x > 5; //passing the lambda code into an expression<> tree
        Console.WriteLine(exp.Body); //Body is the main operation of et 
    }
}