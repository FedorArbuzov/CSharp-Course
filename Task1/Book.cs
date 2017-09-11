using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train1
{
    [Serializable]
    public class Book
    {

        // empty constructor for serialization
        public Book() { }


        public Book(int Pages, string Author, string Name, DateTime Date, bool Present, int Price) {
            pages = Pages;
            author = Author;
            name = Name;
            date = Date;
            present = Present;
            price = Price;     
        }

        // fields for serialization 
        public int pages { get; set; }
        public string author { get; set; }
        public string name { get; set; }
        public DateTime date { get; set; }
        public bool present { get; set; }
        public int price { get; set; }


        public override string ToString()
        {
            return "\n Pages: " + Convert.ToString(pages)
                + "\n " + "Author: " + author
                + "\n " + "Name: " + name
                + "\n " + "Present: " + (present ? "Yes" : "No")
                + "\n " + "Price: " + Convert.ToString(pages);
        }
    }
}
