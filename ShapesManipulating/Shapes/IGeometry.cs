using System;

namespace Shapes
{
 
    public interface IGeometry : IComparable
    {
        double Square { get; }
        double Diameter { get;  }
    }
}