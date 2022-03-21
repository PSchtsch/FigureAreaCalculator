using NUnit.Framework;
using FigureAreaCalculator;
using System.Collections.Generic;

namespace FigureAreaCalculatorTests
{
    public class Tests
    {
        private IClosedGeometryFigure circle;
        private IClosedGeometryFigure zeroCircle;
        private IClosedGeometryFigure negativeCircle;

        private IClosedGeometryFigure invalidTriangle;
        private IClosedGeometryFigure rectangularTriangle;
        private IClosedGeometryFigure negativeInvalidTriangle;
        private IClosedGeometryFigure rectangularInvalidTriangle;

        private List<IClosedGeometryFigure> polygons;


        [SetUp]
        public void Setup()
        {
            circle = ClosedGeometryFigureFabric.CreateCircle(42);
            zeroCircle = ClosedGeometryFigureFabric.CreateCircle(0);
            negativeCircle = ClosedGeometryFigureFabric.CreateCircle(-69);

            invalidTriangle = ClosedGeometryFigureFabric.CreareTriangle(1, 2, 3);
            rectangularTriangle = ClosedGeometryFigureFabric.CreareTriangle(3, 4, 5);
            negativeInvalidTriangle = ClosedGeometryFigureFabric.CreareTriangle(-4.2, 0, -6.9);
            rectangularInvalidTriangle = ClosedGeometryFigureFabric.CreareTriangle(-3, -4, -5);

            polygons = new List<IClosedGeometryFigure>
            {
                circle,
                zeroCircle,
                negativeCircle,

                invalidTriangle,
                rectangularTriangle,
                negativeInvalidTriangle,
                rectangularInvalidTriangle
            };
        }

        [Test]
        public void CircleArea()
        {
            Assert.Pass();
        }

        [Test]
        public void ZeroCircleArea()
        {
            Assert.Pass();
        }

        [Test]
        public void NegativeCircleArea()
        {
            Assert.Pass();
        }

        [Test]
        public void IsTriangleValid()
        {
            Assert.Pass();
        }

        [Test]
        public void IsTriangleRectangular()
        {
            Assert.Pass();
        }

        [Test]
        public void TriangleArea()
        {
            Assert.Pass();
        }

        [Test]
        public void AllFiguresArea()
        {
            Assert.Pass();
        }
    }
}