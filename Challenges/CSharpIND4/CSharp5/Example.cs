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
            Task<string> task = client.GetStringAsync("https://csharpindepth.com/");
            string result = await task;
            return result;
        }
    }
}