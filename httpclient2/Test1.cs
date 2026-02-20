using Microsoft.VisualStudio.TestTools.UnitTesting; //this gives access to the testclass, test method and Asserts
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace HttpClientTests
{
    [TestClass]
    public class TestGetEndPoint
    {
        private string getUrl = "https://jsonplaceholder.typicode.com/posts/1";

        [TestMethod]
        public async Task TestGetAllEndPoint()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                // Send GET request
                HttpResponseMessage response = await httpClient.GetAsync(getUrl);

                // Validate Status Code
                Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);

                // Read Response Body
                string responseBody = await response.Content.ReadAsStringAsync();

                // Validate Response is not empty
                Assert.IsFalse(string.IsNullOrEmpty(responseBody));

                Console.WriteLine("Response:");
                Console.WriteLine(responseBody);
            }
        }
    }
}