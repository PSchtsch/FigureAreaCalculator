using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureAreaCalculator.Figures
{
    public class Circle : IClosedGeometryFigure
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateArea()
        {
            var area = Math.PI * Math.Pow(Radius, 2);
            return area;
        }
    }
}
