using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Counter3
    {
            public int counter = 0;

            public void Counter3FromList(int i)
            {
                if ((i % 3) == 0)
                {
                    counter++;
                }
            }
        }
    }

