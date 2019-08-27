using System;
using System.Globalization;

namespace Challenges.CSharpIND4.CSharp6
{
    public class NewStrings
    {
        private string _name = "Andy";

        public void Test()
        {
            Console.WriteLine("What's your name");
            var name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");
        }

        public void Money()
        {
            decimal price = 95.25m;
            decimal tip = price * 0.2m;
            var a = $"Price: {price,9:c}";
            var b = a.ToString(CultureInfo.GetCultureInfo("en-US"));
            Console.WriteLine($"Price: {price,9:c}");
            Console.WriteLine($"Tip: {tip,9:c}");
            Console.WriteLine($"Total: {price + tip,9:c}");
            Console.WriteLine($@"Price: {price,9:c}
                Tip: {tip,9:c}
                Total: {tip + price,9:c}");
        }

        public void StringTest()
        {
            var culture = CultureInfo.GetCultureInfo("en-US");
            decimal price = 95.25m;

            FormattableString formattableString = $"Price: {price}";
            var result = formattableString.ToString(culture);

            string s = $"Price: {price}";
            var another = s.ToString(culture);
        }
    }
}