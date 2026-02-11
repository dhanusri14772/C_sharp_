using System;
using System.Collections.Generic;
using System.Linq; // 1. Added for Filtering (LINQ)
using System.IO;   // 2. Added for Saving Files
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

public class User {
    public int id { get; set; }
    public string name { get; set; }
    public string email { get; set; }
}
[JsonSerializable(typeof(List<User>))]
internal partial class MyJsonContext : JsonSerializerContext { }
public class Pro {
    static readonly HttpClient client = new HttpClient();

    public static async Task Main() {
        string url = "https://jsonplaceholder.typicode.com/users";
        try {
            // STEP 1: Fetch Data
            Console.WriteLine("--- Fetching data from server ---");
            string jsonText = await client.GetStringAsync(url);
            List<User> allUsers = JsonSerializer.Deserialize(jsonText, MyJsonContext.Default.ListUser) ?? new();
            // STEP 2: User Interaction
            Console.Write("\nEnter a name or part of a name to search for: ");
            string searchKeyword = Console.ReadLine() ?? "";
            // STEP 3: Filtering (The LINQ "Magic")
            // This finds users where the name contains your search word (ignoring capital letters)
            var filteredUsers = allUsers
                .Where(u => u.name.Contains(searchKeyword, StringComparison.OrdinalIgnoreCase))
                .ToList();
            // STEP 4: Display and Save
            if (filteredUsers.Any()) {
                Console.WriteLine($"\nFound {filteredUsers.Count} matches:");
                // We will prepare a string to save to the file
                string fileContent = "Search Results:\n";
                foreach (var user in filteredUsers) {
                    string info = $"- ID: {user.id}, Name: {user.name}, Email: {user.email}";
                    Console.WriteLine(info);
                    fileContent += info + "\n"; 
                }
                // STEP 5: Writing to File
                File.WriteAllText("results.txt", fileContent);
                Console.WriteLine("\n[SUCCESS] Results have been saved to 'results.txt'");
            }
            else {
                Console.WriteLine("No users found matching that name.");
            }
        }
        catch (Exception e) {
            Console.WriteLine("An error occurred: " + e.Message);
        }
    }
}