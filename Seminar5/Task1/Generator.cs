using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

    class Generator
    {
        public event Action<int> myEvent = delegate { }; // пустой делегат
        static Random rnd = new Random();
        public List<int> Generate(int N)
        {
            List<int> list = new List<int>();
            for (int k = 0; k < N; k++)
            {
                int next = rnd.Next(0, 100);
                list.Add(next);
                if (next % 2 == 0 || next % 3 == 0 || next % 5 == 0)
                    myEvent(next);
            }
            return list;
        }
    }
}
