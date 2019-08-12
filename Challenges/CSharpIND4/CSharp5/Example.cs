using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Challenges.CSharpIND4.CSharp5
{
    public class Example
    {
        private readonly HttpClient client = new HttpClient();

        public async Task Async()
        {
            Console.WriteLine(await Fetch());
        }

        private async Task<string> Fetch()
        {
            Console.WriteLine("Fecthing");
            var result = await client.GetStringAsync("https://csharpindepth.com/");
            return result;
        }
    }
}