using System;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Diagnostics; 
public class NasaPhoto
{
    public string title { get; set; }
    public string explanation { get; set; }
    public string url { get; set; } 
    public string date { get; set; }
}
[JsonSerializable(typeof(NasaPhoto))]
internal partial class NasaContext : JsonSerializerContext { }
public class Pro
{
    static readonly HttpClient client = new HttpClient();
    public static async Task Main()
    {
        string url = "https://api.nasa.gov/planetary/apod?api_key=DEMO_KEY";
        try
        {
            Console.WriteLine("Connecting to NASA Mission Control...");
            string jsonText = await client.GetStringAsync(url);
            NasaPhoto photo = JsonSerializer.Deserialize(jsonText, NasaContext.Default.NasaPhoto);
            if (photo != null)
            {
                Console.WriteLine($"\nSUCCESS! Today's Discovery: {photo.title}");
                Console.WriteLine($"Date: {photo.date}");
                Console.WriteLine(new string('-', 50));
                Console.WriteLine(photo.explanation);
                Console.WriteLine(new string('-', 50));
                Console.WriteLine("\nOpening the image in your browser...");
                Process.Start(new ProcessStartInfo
                {
                    FileName = photo.url,
                    UseShellExecute = true 
                });
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Houston, we have a problem: " + e.Message);
        }
    }
}