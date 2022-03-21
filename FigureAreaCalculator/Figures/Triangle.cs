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

        public bool isValid => IsTringleValid();

        private bool IsTringleValid()
        {
            var isValid = (ASide + BSide > CSide) && (BSide + CSide > ASide) && (CSide + ASide > BSide);
            return isValid;
        }

        public bool IsRectangular => IsTriangleRectangular();

        private bool IsTriangleRectangular()
        {
            if (!isValid)
            {
                return false;
            }

            var triangleEdgesLengths = new List<double> { ASide, BSide, CSide };
            var lengths = triangleEdgesLengths.OrderByDescending(length => length).ToList();
            var isTriangleRectangular = Math.Pow(lengths[0], 2) == Math.Pow(lengths[1], 2) + Math.Pow(lengths[2], 2);

            return isTriangleRectangular;
        }

        public Triangle(double aSide, double bSide, double cSide)
        {
            ASide = aSide;
            BSide = bSide;
            CSide = cSide;
        }

        public double CalculateArea()
        {
            if (!isValid)
            {
                return 0;
            }

            var halfPerimeter = (ASide + BSide + CSide) / 2;
            var area = Math.Sqrt(halfPerimeter
                                 * (halfPerimeter - ASide)
                                 * (halfPerimeter - BSide)
                                 * (halfPerimeter - CSide));

            return area;
        }
    }
}
