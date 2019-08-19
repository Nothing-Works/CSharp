namespace Challenges.CSharpIND4.CSharp6
{
    public class Properties
    {
        //fields
        public double XPoint;
        public double YPoint;

        //C#1 
        private double x1, y1;

        public double X1
        {
            get { return x1; }
            set { x1 = value; }
        }

        public double Y1
        {
            get { return y1; }
            set { y1 = value; }
        }

        //C#2
        private double x2, y2;

        public double X2
        {
            get { return x2; }
            private set { x1 = value; }
        }

        public double Y2
        {
            get { return y2; }
            private set { y2 = value; }
        }

        //C#3
        public double X3 { get; set; }
        public double Y3 { get; set; }

        //C#3 Read only
        private readonly double xRead, yRead;

        public double XRead
        {
            get { return xRead; }
        }
        public double YRead
        {
            get { return yRead; }
        }
        public Properties(double x, double y)
        {
            xRead = x;
            yRead = y;
        }

        //C#3 Read only cheated way, and only can be set via constructor.
        public double XReadChated { get; private set; }
        public double YReadChated { get; private set; }

        //C#6 Read only properties
        public int XReadOnly6 { get; }
        public int YReadOnly6 { get; }

        public Properties(int x, int y)
        {
            XReadOnly6 = x;
            YReadOnly6 = y;
        }

        public void Test()
        {
            //u cant do this as it's readonly.
            //XReadOnly6 = 1;
        }
    }
}