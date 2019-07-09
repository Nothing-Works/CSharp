using System;

namespace Challenges.CSharpIND3.CSharp2.PartialTypes
{
    public partial class Example<TFirst, TSecond> : EventArgs, IDisposable
    {
        public void Dispose()
        {
        }
    }
}