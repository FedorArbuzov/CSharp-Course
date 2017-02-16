using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

    public delegate double ExpDel(double x);

    public delegate void ExpChanged(ExpDel ex);

    class Expression
    {
        // TODO2: Объявить событие OnExpChanged типа ExpChanged
        public event ExpChanged OnExpChanged;


        ExpDel ex; // Поле для ссылки на метод-выражение
        public Expression(ExpDel e)
        { // Конструктор
            ex = e;
        }
        public double ExVal(double x)
        {
            return ex(x);
        }
        // TODO3: При обновлении выражения в аксессорe
        // инициировать событие:
        public ExpDel Ex { set { ex = value; OnExpChanged(ex); } }
    }
}
