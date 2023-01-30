using Newtonsoft.Json;
using System.Text.Json.Serialization;

class MyClass
{
    public static async Task Main(string[] args)
    {
         await ReadData();
        

    }

    private static async Task ReadData()
    {
        var httpClient = new HttpClient();
        Console.WriteLine("Fetching data from api...");
        var result = await httpClient.GetAsync("https://ps-async.fekberg.com/api/stocks/MSFT");
        result.EnsureSuccessStatusCode();

        var content = await result.Content.ReadAsStringAsync();

        //var data = JsonConvert.DeserializeObject<IEnumerable<string>>(content);
        if (content != null)
        {
            Console.WriteLine("So Data");
            foreach (var item in content)
            {
                Console.Write(item);
            }
        }
    }
}