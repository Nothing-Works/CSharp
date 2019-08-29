using System;
using System.Threading;

namespace Challenges.CSharpIND4.CSharp6
{
    public class ExceptionFilters
    {
        public T Retry<T>(Func<T> operation, int attempts)
        {
            while (true)
            {
                try
                {
                    attempts--;
                    return operation();
                }
                catch (Exception e) when (attempts > 0)
                {
                    Console.WriteLine($"Failed: {e}");
                    Console.WriteLine($"Attempts left: {attempts}");
                    Thread.Sleep(5000);
                }
            }
        }

        public void Go()
        {
            Func<DateTime> temporamentalCall = () =>
            {
                DateTime date = DateTime.UtcNow;

                if (date.Second < 20)
                {
                    throw new Exception("I don't like the start of a minute");
                }

                return date;
            };

            var result = Retry(temporamentalCall, 3);
            Console.WriteLine(result);
        }

        public void Test()
        {
            string[] messages =
            {
                "You can catch this",
                "You can catch this too",
                "This won't be caught"
            };

            foreach (string message in messages)
            {
                try
                {
                    throw new Exception(message);
                }
                catch (Exception e) when (e.Message.Contains("catch"))
                {
                    Console.WriteLine($"Caught '{e.Message}'");
                }
            }
        }
    }
}