using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Pikture.Client
{
  class Program
  {
    async static Task Main(string[] args)
    {
      await RestApiAsync();
      System.Console.WriteLine("END");
      Console.ReadLine();
    }

    async static Task RestApiAsync()
    {
      var http = new HttpClient();

      var response = http.GetAsync("http://localhost:5000/api/image").GetAwaiter().GetResult();
      var response2 = await http.GetAsync("http://localhost:5000/api/image");

      System.Console.WriteLine(await response.Content.ReadAsStringAsync());
    }
  }
}
