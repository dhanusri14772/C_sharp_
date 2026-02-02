public class program
{
    static void Main()
    {
        string inp = Console.ReadLine();
        File.WriteAllText("input.txt", inp);
        string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string fullPath = Path.Combine(desktop, "input.txt");
        Console.WriteLine(fullPath);
    }
}