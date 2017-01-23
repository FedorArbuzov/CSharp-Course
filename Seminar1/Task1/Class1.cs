using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
     public delegate int Cast(double x);   // делегат-тип

    public class Class1
    {
        // ближайшее четное целое
        public static Cast cast1 = delegate (double z)
        { return (int)(Math.Round(z / 2) * 2); };

        // порядок положительного числа 
        public static Cast cast2 = delegate (double z)
        { return (int)Math.Log10(z); };

    }
}
