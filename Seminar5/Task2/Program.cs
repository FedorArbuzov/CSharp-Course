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
            Expression me = new Expression(x => { return x * x + 2 * x - 3; });
            ValueStore vs = new ValueStore(me, 0);
            // TODO5: Подписать объект vs на события объекта me
            Console.WriteLine(vs.CurrVal);
            // изменяем выражение:
            me.Ex = x => { return Math.Sqrt(Math.Abs(x)); };
            Console.WriteLine(vs.CurrVal);
            me.Ex = x => { return Math.Sin(x); };
            Console.WriteLine(vs.CurrVal);
            me.Ex = x => { return x * x * x - 1; };
            Console.WriteLine(vs.CurrVal);
            Console.ReadKey();

        }
    }
}
