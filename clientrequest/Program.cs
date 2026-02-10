using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
public class User
{
    public int id {get;set;}
    public string name {get; set;}
    public string email {get;set;}
}
public class Pro
{
    static readonly HttpClient client = new HttpClient();
    public static async Task Main()
    {
        string url = "https://jsonplaceholder.typicode.com/users/1";
        string jsonText = await client.GetStringAsync(url);
        User myuser = JsonSerializer.Deserialize<User>(jsonText);
        Console.WriteLine("Name is " + myuser.name);
    }

}