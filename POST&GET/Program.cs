using Integration.Models;
using Integration.Services;

class Program
{
    static async Task Main()
    {
        using HttpClient client = new HttpClient();
        ApiService api = new ApiService(client);
        var post = await api.GetPostAsync("https://jsonplaceholder.typicode.com/posts/1");

        if (post != null)
        {
            Console.WriteLine($"UserId : {post.userId}");
            Console.WriteLine($"Title  : {post.title}");
            Console.WriteLine($"Body   : {post.body}");
        }
        Order order = new Order
        {
            orderId = 1001,
            customer = "ABC Pvt ltd",
            amount = 4500
        };
        var result = await api.SendOrderAsync(order);
        if (result != null)
        {
            Console.WriteLine("POST Response:");
            Console.WriteLine(result);
        }
    }
}