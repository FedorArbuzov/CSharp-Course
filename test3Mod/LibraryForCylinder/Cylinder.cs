using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryForCylinder
{
    public class Cylinder
    {
        private double h;
        private double r;

        public Cylinder(double H, double R) {
            h = H;
            r = R;
        }

        public double V(){
            return h * r * r * Math.PI;
        }

        public override string ToString()
        {
            return "H=" + Convert.ToString(h) + ", R=" + Convert.ToString(r) + ", V=" + Convert.ToString(V());
        }

        public string forFile() {
            return Convert.ToString(h) + "  " + Convert.ToString(r);
        }
    }
}
