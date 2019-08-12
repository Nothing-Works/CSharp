using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Challenges.CSharpIND4.CSharp5
{
    public class Example
    {
        private readonly HttpClient client = new HttpClient();

        public void Async()
        {
            Task<string> result = Fetch();
            Console.WriteLine(result.Result);
        }

        private async Task<string> Fetch()
        {
            Console.WriteLine("Fecthing");
            Task<string> task = client.GetStringAsync("https://csharpindepth.com/");
            string result = await task;
            return result;
        }

        private Task<int> Test()
        {
            return Task.Run(() => 1);
        }
    }
}