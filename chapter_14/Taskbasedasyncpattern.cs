using System;
using System.Net.Http;
using System.Threading.Tasks;
class Program
{
    static async Task Main()
    {
        Console.WriteLine("starting download....");
        string content = await GetWebPageContentAsync("http://www.google.com");
        Console.WriteLine("download complete . first 100 chars");
        Console.WriteLine(content.Substring(0,100));
    }
static async Task<string> GetWebPageContentAsync(string url)
{
    using  (var client = new HttpClient())
        {
            string result = await client.GetStringAsync(url);
            return result;
        }
}}