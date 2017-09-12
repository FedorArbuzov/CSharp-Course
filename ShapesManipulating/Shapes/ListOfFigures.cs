using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml;

namespace Shapes
{
    [Serializable]
    public class ListOfFigures<T> : IGeometry
    {
        
        public readonly List<T> listOfFigures = new List<T>();
        
        public ListOfFigures (List<T> listInput)
        {
            listOfFigures = listInput;
        }

        public ListOfFigures()
        {
            ;
        }

        public int CompareTo(object obj)
        {
            throw new System.NotImplementedException();
        }

        public static ListOfFigures<T> operator +(ListOfFigures<T> l1, ListOfFigures<T> l2)
        {
            return new ListOfFigures<T>(l1.FiguresList.Concat(l2.FiguresList).ToList());
        }

        public double Square => listOfFigures.Sum(figure => ((IGeometry)figure).Square);
        public double Diameter => listOfFigures.Max(figure => ((IGeometry)figure).Diameter);
        
        public List<T> FiguresList => listOfFigures;
    }
}