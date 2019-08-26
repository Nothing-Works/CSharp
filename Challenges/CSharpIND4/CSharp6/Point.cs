namespace Challenges.CSharpIND4.CSharp6
{
    public struct Point
    {
        //        Before C#6
        //        public double X { get; private set; }
        //        public double Y { get; private set; }
        //
        //        public Point(double x, double y) : this()
        //        {
        //            X = x;
        //            Y = y;
        //        }

        public int X1 { get; }
        public int Y1 { get; }

        public Point(int x, int y)
        {
            X1 = x;
            Y1 = y;
        }
    }
}