using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Challenges.CSharpIND3.CSharp5
{
    public class Example
    {
        public async Task Sync()
        {
            await Internals();
        }

        private async Task Internals()
        {
            var watch = Stopwatch.StartNew();
            Console.WriteLine("started");
            await Task.Delay(3000);
            watch.Stop();
            Console.WriteLine("done");
            Console.WriteLine(watch.ElapsedMilliseconds);
        }
    }
}