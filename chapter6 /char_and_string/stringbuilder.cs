using System;
using System.Text;
class stringBuilder
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder(); //creates mutable text buffer
        sb.Append("Hello");
        sb.Append(" ");
        sb.Append("World");
        Console.WriteLine(sb.ToString()); //converts buffer to regular string 
        sb.Length = 0;   // clears the previous content
        sb.Append("New text");
        Console.WriteLine(sb.Length);
        Console.WriteLine(sb.ToString());
    }
}
