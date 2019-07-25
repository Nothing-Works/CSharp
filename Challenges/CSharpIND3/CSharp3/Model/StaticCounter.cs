namespace Challenges.CSharpIND3.CSharp3.Model
{
    public static class StaticCounter
    {
        static int next = 1;

        public static int Next()
        {
            return next++;
        }
    }
}