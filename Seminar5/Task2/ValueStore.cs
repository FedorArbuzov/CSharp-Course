using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ValueStore
    {
            Expression exp;
            double x0; // точка - абсцисса
            double expCurrValue; // хранимое значение в x0
            public ValueStore(Expression e1, double x0)
            {
                exp = e1;
                this.x0 = x0;
                expCurrValue = exp.ExVal(x0);
            }
            public double CurrVal { get { return expCurrValue; } }
        // TODO4: Определить метод OnExpChangedHandler(),
        // изменяющий значение поля expCurrValue
        // на значение выражения exp в точке x0

        public void OnExpChangedHandler(ExpDel ed) {
            expCurrValue = ed(x0);
        }
    }
}

