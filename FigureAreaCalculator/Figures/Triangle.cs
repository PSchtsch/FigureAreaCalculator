using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureAreaCalculator.Figures
{
    public class Triangle : IClosedGeometryFigure
    {
        public double ASide { get; }
        public double BSide { get; }
        public double CSide { get; }

        public bool IsRectangular => IsTriangleRectangular();

        private bool IsTriangleRectangular()
        {
            throw new NotImplementedException();
        }

        public Triangle(double aSide, double bSide, double cSide)
        {
            ASide = aSide;
            BSide = bSide;
            CSide = cSide;
        }

        public double CalculateArea()
        {
            throw new NotImplementedException();
        }
    }
}
