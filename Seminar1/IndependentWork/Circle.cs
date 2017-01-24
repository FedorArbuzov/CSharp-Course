using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    
    
    class Circle
    {
        
        public Circle(double _x, double _y, double  _rad) {
            x = _x;
            y = _y;
            rad = _rad;
        }
        double x, y, rad;
        public override string ToString() {
            return "Circle x:" + x + " y:" + y + " rad: " + rad + String.Format(" S: {0:N}", Sq()); 
        }

        public double Sq(){
            return Math.PI * rad * rad;
        }
    }
}
