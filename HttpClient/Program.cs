using System;
using System.Net.Http;
using System.Threading.Tasks;
class program
{
    static async Task Main()
    {
        HttpClient client = new HttpClient();
        HttpResponseMessage response = await client.GetAsync("https://jsonplaceholder.typicode.com/posts/1");
        string content = await response.Content.ReadAsStringAsync();
        Console.WriteLine(content);
    }
}
