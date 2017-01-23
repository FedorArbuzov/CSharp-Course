using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication1
{
    delegate int Lam(int x);
    delegate int Lam1(int x, int i, int j);

    class Program
    {
        static void Main(string[] args)
        {
            Lam1 Plus = (x, i, j) => i * x / j;

            Lam Mul = (x) =>
            {
                int proiz = 0;
                for (int i = 1; i < 5; i++)
                {
                    int proiz_loc = 1;
                    for (int j = 1; j < 5; j++)
                    {
                        proiz_loc *= Plus(x, i, j);
                        //Console.WriteLine(Plus(x, i, j));
                    }
                    proiz += proiz_loc;
                }
                return proiz;
            };
            Console.WriteLine(Mul(10));
            Console.ReadKey();



            
        }
    }
}
