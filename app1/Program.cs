using System;
using System.Net.Http;

namespace app1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var httpClient = new HttpClient()
            {
                Timeout = TimeSpan.FromSeconds(1)
            })
            {
                httpClient.BaseAddress = new Uri("http://169.254.169.254");
                var response = httpClient.GetStringAsync("").Result;
                Console.Out.WriteLine(response);
            }
            Console.WriteLine("Hello World!");
        }
    }
}
