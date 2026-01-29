using System;
public class Arrays
{
    public static void Main()
    {
        char[] vowels = new char[5]; 
        vowels[0] = 'a';
        vowels[1] = 'e';
        vowels[2] = 'i';
        vowels[3] = 'o';
        vowels[4] = 'u';
        Console.WriteLine (vowels[1]); 
        for (int i = 0; i < vowels.Length; i++)
            Console.Write (vowels[i]); 
    }
}