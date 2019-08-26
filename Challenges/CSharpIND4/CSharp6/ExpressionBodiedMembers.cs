using System;

namespace Challenges.CSharpIND4.CSharp6
{
    public class ExpressionBodiedMembers
    {
        public double X { get; }
        public double Y { get; }

        public ExpressionBodiedMembers(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double DistanceFromOrigin
        {
            get { return Math.Sqrt(X * X + Y * Y); }
        }

        //C#6
        public double DistanceFromOrigin1 => Math.Sqrt(X * X + Y * Y);

        public int AddTwo(int x, int y)
        {
            return x + y;
        }

        public int AddTwo1(int x, int y) => x + y;
    }
}