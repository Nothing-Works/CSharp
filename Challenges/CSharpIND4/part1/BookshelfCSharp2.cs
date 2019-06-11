using System.Collections.Generic;

namespace Challenges.CSharpIND4.part1
{
    public class BookshelfCSharp2
    {
        public IEnumerable<Book> Books
        {
            get { return new Book[] { new Book(), new Book() }; }
        }
    }
}