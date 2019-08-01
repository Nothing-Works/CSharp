using System;

namespace Challenges.CSharpIND4.CSharp4
{
    public class OptionalParametersNamedArguments
    {
        public void Go(int x, int y = 5, int z = 10)
        {
            Console.WriteLine("x={0}; y={1}; z={2}", x, y, z);
        }
    }
}