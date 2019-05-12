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
            {
                var result = paymentProcessor.MakePayment($"Demo{i}", i);

                Console.WriteLine(result.TransactionAmount);
            }

            Console.ReadLine();
        }
    }
}