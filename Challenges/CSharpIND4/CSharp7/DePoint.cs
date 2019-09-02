namespace Challenges.CSharpIND4.CSharp7
{
    public class DePoint
    {
        public int X { get; set; }
        public int Y { get; set; }


        public DePoint(int x, int y) => (X, Y) = (x, y);

        public void Deconstruct(out int x, out int y) => (x, y) = (X, Y);
    }
}