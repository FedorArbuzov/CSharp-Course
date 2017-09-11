using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train1
{
    class Library : Storage<Book>
    {
        public override void addBook(Book book)
        {
            books.Add(book);
            //throw new NotImplementedException();
        }

        public override bool compareBook()
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Book> getAllPresents()
        {
            var new_books = books.Where(book => (book.present));
            //foreach (Book book in new_books) {
            //    Console.WriteLine(book);
            //}

            return new_books;
                //throw new NotImplementedException();
        }
    }
}
