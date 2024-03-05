namespace API_requests_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            using(var client = new HttpClient())
            {
                var endpoint = new Uri("https://catfact.ninja/fact");
                var result = client.GetAsync(endpoint).Result.Content.ReadAsStringAsync().Result;
                Console.WriteLine(result);
            }
        }
    }
}