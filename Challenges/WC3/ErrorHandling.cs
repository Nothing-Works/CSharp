using DemoLibrary;
using System;

namespace Challenges.WC3
{
    public class ErrorHandling
    {
        public void ErrorHappens()
        {
            var paymentProcessor = new PaymentProcessor();

            for (var i = 0; i <= 10; i++)
                try
                {
                    var result = paymentProcessor.MakePayment($"Demo{i}", i);
                    Console.WriteLine(result.TransactionAmount);
                }
                catch (NullReferenceException e)
                {
                    Console.WriteLine($"Null Value for item {i} {e.Message}");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Payment skipped for payment with {i} items {e.Message}");
                }

            Console.ReadLine();
        }
    }
}