using System;

namespace Challenges.CSharpIND4.CSharp3.Lambda
{
    public class CapturedVariables
    {
        private string instanceField = "instance field";

        public Action<string> CreateAction(string methodParameter)
        {
            string methodLocal = "method local";
            string uncaptured = "uncaptured local";

            Action<string> action = lamdaParemeter =>
            {
                string lambdaLocal = "lambda local";
                Console.WriteLine("Instance field : {0}", instanceField);
                Console.WriteLine("Method parameter : {0}", methodParameter);
                Console.WriteLine("Method local : {0}", methodLocal);
                Console.WriteLine("lambda parameter : {0}", lamdaParemeter);
                Console.WriteLine("Lambda Local : {0}", lambdaLocal);
            };

            return action;
        }
    }
}