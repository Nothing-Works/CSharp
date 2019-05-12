using Challenges.WC2;

namespace Challenges
{
    public static class Program
    {
        private static void Main()
        {
            var c = new ReadAndWriteFile();
            c.ReadFile();
            c.PrintOut();
            c.WriteFile();
        }
    }
}