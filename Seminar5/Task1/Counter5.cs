using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Counter5
    {
            public int counter = 0;

            public void Counter5FromList(int i)
            {
                if ((i % 5) == 0)
                {
                    counter++;
                }
            }
        }
    }

