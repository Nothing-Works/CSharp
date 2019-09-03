using Challenges.CSharpIND4.CSharp7.BaseClasses;
using System;

namespace Challenges.CSharpIND4.CSharp7
{
    public class PatternMatching
    {
        //before c# 6
        public string Go(Shape shape)
        {
            if (shape == null)
                throw new ArgumentNullException(nameof(shape));

            Rectangle rect = shape as Rectangle;
            if (rect != null)
                return "rect";

            Circle circle = shape as Circle;
            if (circle != null)
                return "circle";

            Triangle tri = shape as Triangle;
            if (tri != null)
                return "Triangle";

            throw new ArgumentException(
                $"Shape type {shape.GetType()} perimeter unknown", nameof(shape));
        }

        //c#7 with pattern matching
        public string Go7(Shape shape)
        {
            switch (shape)
            {
                case null:
                    throw new ArgumentNullException(nameof(shape));
                case Rectangle rect:
                    return "Rect";
                case Circle circle:
                    return "Circle";
                case Triangle tri:
                    return "Triangle";
                default:
                    throw new ArgumentException(
                        $"Shape type {shape.GetType()} perimeter unknown", nameof(shape));
            }
        }

        public void ConstantPattern(object input)
        {
            if (input is "hello")
                Console.WriteLine("Input is string hello");
            if (input is 5L)
                Console.WriteLine("Input is long 5");
            if (input is 10)
                Console.WriteLine("Input is int 10");
            else
                Console.WriteLine("Input didn't match hello, long 5 or int 10");
        }

        public string TypePattern(Shape shape)
        {
            if (shape == null)
                throw new ArgumentNullException(nameof(shape));

            if (shape is Rectangle rec)
                return "rect";

            if (shape is Circle circle)
                return "circle";

            if (shape is Triangle tri)
                return "Triangle";

            throw new ArgumentException(
                $"Shape type {shape.GetType()} perimeter unknown", nameof(shape));
        }

        public int Fib(int n)
        {
            switch (n)
            {
                case 0: return 0;
                case 1: return 1;
                case var _ when n > 1: return Fib(n - 2) + Fib(n - 1);
                default:
                    throw new ArgumentOutOfRangeException(
                        nameof(n), "Input must be non-negative");
            }
        }
    }
}