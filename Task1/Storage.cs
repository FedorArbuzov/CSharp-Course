using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train1
{
    abstract class Storage<T>
    {

        protected List<T> books = new List<T>();

        
        public abstract void addBook(T obj);

        public abstract bool compareBook();

        public abstract IEnumerable<T> getAllPresents();

        public override string ToString()
        {
            string result_string = "";
            int number_of_book = 1;
            foreach (T book in books) {
                result_string += "\n Book" + "\n Number: " + Convert.ToString(number_of_book) + book;
                number_of_book++;
            }

            return result_string;
        }


    }
}
