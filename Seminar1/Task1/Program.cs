using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApplication1
{
    
        
    class Program
    {


        static void Main(string[] args)
        {
            double test = 15.83;

            Console.WriteLine("cast1(test)={0}, cast2(test)= {1}",
               Class1.cast1(test), Class1.cast2(test));
            Console.WriteLine("cast1(4.46)={0}, cast2(4.46)= {1}",
                Class1.cast1(4.46), Class1.cast2(4.46));

        }
    }
}
