using Bot_Console.POCO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;

namespace BizBot
{
    public class Scrape
    {
        public string JsonURL { get; set; }
        public Catalog catalog { get; set; }

        public Scrape(string url)
        {
            JsonURL = url;
        }

        public async void scrapeChanAsync()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept
                .Add(new MediaTypeWithQualityHeaderValue("application/json"));
            try
            {
                HttpResponseMessage response = await client.GetAsync(JsonURL);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                Catalog? cat = JsonSerializer.Deserialize<Catalog>(responseBody);
                catalog = cat;
            }
            catch(Exception ex)
            {
                Console.WriteLine($"responseBody has the error: {ex}");
            }

        }

    }

}