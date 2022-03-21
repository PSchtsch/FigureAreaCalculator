using FigureAreaCalculator.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureAreaCalculator
{
    public class ClosedGeometryFigureFabric
    {
        public static IClosedGeometryFigure CreateCircle(double radius)
        {
            return new Circle(radius);
        }

        public static IClosedGeometryFigure CreareTriangle(double aSide, double bSide, double cSide)
        {
            return new Triangle(aSide, bSide, cSide);
        }
    }
}
