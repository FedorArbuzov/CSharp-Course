using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using Shapes;

namespace ShapesInput
{

    internal class Program
    {
        public static void Main(string[] args)
        {
            Triangle triangle = new Triangle(3, 3, 3);
            Circle circle = new Circle(12);
            
            ListOfFigures<IGeometry> listOfFigures = 
                new ListOfFigures<IGeometry>(new List<IGeometry>(){triangle, circle});
            
            
            var formatter = new XmlSerializer(listOfFigures.GetType(),
                new Type[]{typeof(Triangle), typeof(Circle)});

            using (FileStream fs = new FileStream("/home/fedor/lf.xml", FileMode.OpenOrCreate))
            {
                Console.WriteLine(listOfFigures);
                formatter.Serialize(fs, listOfFigures);
            }
            
            using (FileStream fs = new FileStream("/home/fedor/lf.xml", FileMode.OpenOrCreate))
            {
                var listOfFiguresNew = (ListOfFigures<IGeometry>)formatter.Deserialize(fs);
                Console.WriteLine(listOfFiguresNew);
            }
            
            
        }
    }
}