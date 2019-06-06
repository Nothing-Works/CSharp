using System;

namespace Challenges.WC6
{
    public class DotnetDataTime
    {
        public void Start()
        {
            Console.WriteLine("Give me a data");
            var dateString = Console.ReadLine();
            var dateTime = DateTime.Parse(dateString);
            Console.WriteLine((DateTime.Now - dateTime).TotalDays);
        }
    }
}