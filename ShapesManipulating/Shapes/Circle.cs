using System;

namespace Shapes
{
    
    ///<summary>
    /// class for circle business-logic
    ///</summary>
    [Serializable]
    public class Circle : IGeometry
    {
        
        ///<summary>
        /// triangle sides
        ///</summary>
        public double R;

        ///<summary>
        /// method for params check
        ///</summary>
        private bool  validateCircle(double r)
        {
       
            // good circle case    
            return r > 0;
        }

        private double SquareCircle()
        {
            return Math.PI * R * R;
        }

        ///<summary>
        /// constructor for triangle
        ///</summary>
        public Circle(double r)
        {
            if (!validateCircle(r))
            {
                throw new ArgumentException("Please, check triangle params!", "");
            }
            R = r;
        }

        public Circle()
        {
            ;
        }

        ///<summary>
        /// method from IGeometry interface 
        ///</summary>
        public int CompareTo(object obj)
        {
            
            Circle otherCircle = obj as Circle;

            if (otherCircle != null)
            {
                return this.Diameter.CompareTo(otherCircle.Diameter);
            }
            throw new ArgumentException("Object is not a Circle");
        }
        
        ///<summary>
        /// property from IGeometry interface 
        ///</summary>
        public double Square => SquareCircle();
        public double Diameter => R * 2;

        ///<summary>
        /// toString method for triangle class 
        ///</summary>
        public override string ToString()
        {
            return $"Circle: <{R:0.00}>. \n Square=<{Square:0.00}>. Diameter:<{Diameter:0.00}>";
        }
    }
}