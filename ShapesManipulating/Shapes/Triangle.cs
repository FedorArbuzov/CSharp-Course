using System;

namespace Shapes
{
    
    ///<summary>
    /// class for triangle business-logic
    ///</summary>
    [Serializable]
    public class Triangle : IGeometry
    {
        
        ///<summary>
        /// triangle sides
        ///</summary>
        public double A, B, C;

        ///<summary>
        /// method for params check
        ///</summary>
        private bool  validateTriangle(double a, double b, double c)
        {
       
            // good triangle case    
            return a > 0 && b > 0 && c > 0 &&
                   a < b + c &&
                   b < a + c &&
                   c < a + b;
        }

        private double SquareTriangle()
        {
            
            double p = (A + B + C) / 2;

            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        ///<summary>
        /// constructor for triangle
        ///</summary>
        public Triangle(double a, double b, double c)
        {
            if (!validateTriangle(a, b, c))
            {
                throw new ArgumentException("Please, check triangle params!", "");
            }
            A = a;
            B = b;
            C = c;
        }


        public Triangle()
        {
            
        }
        
        ///<summary>
        /// method from IGeometry interface 
        ///</summary>
        public int CompareTo(object obj)
        {
            
            Triangle otherTRiangle = obj as Triangle;

            if (otherTRiangle != null)
            {
                return this.Diameter.CompareTo(otherTRiangle.Diameter);
            }
            throw new ArgumentException("Object is not a Triangle");
        }
        
        ///<summary>
        /// property from IGeometry interface 
        ///</summary>
        public double Square => SquareTriangle();
        public double Diameter => Math.Max(Math.Max(A, B), C);

        ///<summary>
        /// toString method for triangle class 
        ///</summary>
        public override string ToString()
        {
            return $"Triamgle: <{A:0.00}>, <{B:0.00}>, <{C:0.00}>. \n Square=<{Square:0.00}>. Diameter:<{Diameter:0.00}>";
        }
    }
}