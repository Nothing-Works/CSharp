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

        public Task<int> LengthAnonymous(string s)
        {
            if (s == null)
            {
                throw new ArgumentNullException("you passed null");
            }

            Func<string, Task<int>> met = async c =>
            {
                await Task.Delay(3000);
                return c.Length;
            };

            return met(s);
        }

        public Task<int> LengthLocal(string s)
        {
            if (s == null)
            {
                throw new ArgumentNullException("you passed null");
            }

            return Ipl(s);

            async Task<int> Ipl(string t)
            {
                await Task.Delay(3000);
                return t.Length;
            }
        }

        public Task<int> LengthAsync(string s)
        {
            if (s == null)
            {
                throw new ArgumentNullException("you passed null");
            }

            return LengthAsyncIpl(s);
        }

        private async Task<int> LengthAsyncIpl(string s)
        {
            await Task.Delay(3000);
            return s.Length;
        }

        private Task<int> Test()
        {
            return Task.Run(() => 1);
        }
    }
}