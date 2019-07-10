namespace Challenges.CSharpIND4.CSharp3
{
    public class ImplicitTyping
    {
        int[] array = new int[10];

        // Before C# 3.
        int[] array1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
        int[] array2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        //After C# 3.
        int[] array3 = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
    }
}