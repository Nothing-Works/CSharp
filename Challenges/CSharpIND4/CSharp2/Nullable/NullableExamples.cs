using System;

namespace Challenges.CSharpIND4.CSharp2.Nullable
{
    public class NullableExamples
    {
        private static void DisplayNullableValue(Nullable<decimal> maxPrice)
        {
            if (maxPrice.HasValue)
            {
                Console.WriteLine("Maximum price: {0}", maxPrice.Value);
            }
            else
            {
                Console.WriteLine("No maximum price set.");
            }
        }


        private static void NULLCOALESCING()
        {
            int? a = null;
            int b = 2;
            int c = a ?? b;
            Console.WriteLine(c.ToString());
        }

        private static void AsOPERATOR(object o)
        {
            int? a = o as int?;

            Console.WriteLine(a.HasValue ? a.Value.ToString() : "null");
        }

        public static void Display()
        {
            DisplayNullableValue(1.1m);
            DisplayNullableValue(null);
            AsOPERATOR(1);
            AsOPERATOR("andy");
            NULLCOALESCING();
        }
    }
}