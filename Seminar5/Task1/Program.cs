using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter2 c2 = new Counter2();
            Counter3 c3 = new Counter3();
            Counter5 c5 = new Counter5();
            Generator gen = new Generator();

            gen.myEvent += c2.Counter2FromList;
            gen.myEvent += c3.Counter3FromList;
            gen.myEvent += c5.Counter5FromList;
            gen.Generate(100);
            Console.WriteLine(c2.counter);
            Console.WriteLine(c3.counter);
            Console.WriteLine(c5.counter);
            Console.ReadKey();            
        }
    }
}
