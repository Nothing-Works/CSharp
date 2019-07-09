using System;

namespace Challenges.CSharpIND3.CSharp2.PartialTypes
{
    public partial class Example<TFirst, TSecond> : IEquatable<string> where TFirst : class
    {
        public bool Equals(string other)
        {
            return false;
        }
    }
}