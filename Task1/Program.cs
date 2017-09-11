using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Train1
{
    class Program
    {
        static void Main(string[] args)
        {

            Book book0 = new Book(12, "Petya", "1234", new DateTime(2014, 10, 12), true, -1);
            Book book1 = new Book(23, "Petya", "32535", new DateTime(2014, 3, 12), false, -1);

            Library library = new Library();
            library.addBook(book0);
            library.addBook(book1);
            Console.WriteLine(library);

            IEnumerable<Book> present_books = library.getAllPresents();

            foreach (Book book_present in present_books) {
                Console.WriteLine(book_present);
            }

            XmlSerializer formatter = new XmlSerializer(typeof(Book));

            using (FileStream fs = new FileStream(@"C:\Users\student\books.xml", FileMode.OpenOrCreate))
            {

                Console.WriteLine(book0);

                formatter.Serialize(fs, book0);

                Console.WriteLine("Объект сериализован");
            }

            using (FileStream fs = new FileStream(@"C:\Users\student\books.xml", FileMode.OpenOrCreate))
            {

                Book book_new = (Book)formatter.Deserialize(fs);

                Console.WriteLine("Объект десериализован");

                Console.WriteLine(book_new);
            }


            Console.ReadKey();

        }
    }
}
