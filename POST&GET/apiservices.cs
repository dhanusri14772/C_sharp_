using System.Net.Http;
using System.Text;
using System.Text.Json;
using Integration.Models;

namespace Integration.Services
{
    public class ApiService
    {
        private readonly HttpClient _client;
        public ApiService(HttpClient client)
        {
            _client = client;
        }
        public async Task<Post?> GetPostAsync(string url)
        {
            Console.WriteLine("Sending GET request...");
            HttpResponseMessage response = await _client.GetAsync(url);
            Console.WriteLine($"Status Code   : {response.StatusCode}");
            Console.WriteLine($"Reason Phrase : {response.ReasonPhrase}");
            Console.WriteLine($"HTTP Version  : {response.Version}");
            Console.WriteLine("\nResponse Headers:");
    foreach (var header in response.Headers)
    {
        Console.WriteLine($"{header.Key} : {string.Join(",", header.Value)}");
    }
    if (!response.IsSuccessStatusCode)
        return null;
    string body = await response.Content.ReadAsStringAsync();
    Console.WriteLine("\nContent Headers:");
    foreach (var header in response.Content.Headers)
    {
        Console.WriteLine($"{header.Key} : {string.Join(",", header.Value)}");
    }
    return JsonSerializer.Deserialize<Post>(body);
        }
    public async Task<string?> SendOrderAsync(Order order)
        {
            if (order.amount <= 0)
            {
                Console.WriteLine("Invalid order amount.");
                return null;
            }
   string jsonPayload = JsonSerializer.Serialize(order);
   var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");
   HttpResponseMessage response = await _client.PostAsync("https://jsonplaceholder.typicode.com/posts", content);
            if (!response.IsSuccessStatusCode)
            {
                Console.WriteLine($"POST failed: {response.StatusCode}");
                return null;
            }
            return await response.Content.ReadAsStringAsync();
        }
    }
}