using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Counter2
    {
        public int counter = 0;

        public void Counter2FromList(int i) {
            if ((i % 2) == 0)
            {
                counter++;
            } 
        }
    }
}
