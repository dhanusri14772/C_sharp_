using System;
using System.Text;
class encodeUnicode
{
    static void Main()
    {
        string text = "Hello 🌍";
        byte[] utf8Bytes = Encoding.UTF8.GetBytes(text); //converts string to bytes
        byte[] utf16Bytes = Encoding.Unicode.GetBytes(text);
        Console.WriteLine($"UTF-8 bytes: {utf8Bytes.Length}");
        Console.WriteLine($"UTF-16 bytes: {utf16Bytes.Length}");
    }
}
