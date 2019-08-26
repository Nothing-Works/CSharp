using System;

namespace Challenges.CSharpIND4.CSharp7
{
    public class ExBodiedMembers
    {
        static ExBodiedMembers() => Console.WriteLine("Static constructor called");
        ~ExBodiedMembers() => Console.WriteLine("Finalizer called");
        private string name;
        public ExBodiedMembers(string name) => this.name = name;

        public string Name
        {
            get => name;
            set => name = value;
        }
    }
}