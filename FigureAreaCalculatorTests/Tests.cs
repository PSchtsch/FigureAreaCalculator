using NUnit.Framework;
using FigureAreaCalculator;
using System.Collections.Generic;
using FigureAreaCalculator.Figures;

namespace FigureAreaCalculatorTests
{
    public class Tests
    {
        private IClosedGeometryFigure invalidTriangleFigure;
        private IClosedGeometryFigure rectangularTriangleFigure;
        private IClosedGeometryFigure equilateralTriangleFigure;
        private IClosedGeometryFigure rectangularInvalidTriangleFigure;

        [SetUp]
        public void Setup()
        {
            invalidTriangleFigure = ClosedGeometryFigureFabric.CreareTriangle(1, 2, 3);
            rectangularTriangleFigure = ClosedGeometryFigureFabric.CreareTriangle(3, 4, 5);
            equilateralTriangleFigure = ClosedGeometryFigureFabric.CreareTriangle(6, 6, 6);
            rectangularInvalidTriangleFigure = ClosedGeometryFigureFabric.CreareTriangle(-3, -4, -5);
        }

        // Ожидаемая площадь вычислялась с пи равным 3.14
        [TestCase(0, 0)]
        [TestCase(42, 5538.96)]
        [TestCase(-69, 14949.54)]
        public void CircleArea(double radius, double expectedArea)
        {
            IClosedGeometryFigure someCircle = ClosedGeometryFigureFabric.CreateCircle(radius);
            var actualArea = someCircle.CalculateArea();

            double tolerance = 10;
            Assert.AreEqual(expectedArea, actualArea, tolerance);
        }

        [Test]
        public void IsTriangleValid()
        {
            var invalidTriangle = (Triangle)invalidTriangleFigure;
            var rectangularTriangle = (Triangle)rectangularTriangleFigure;
            var equilateralTriangle = (Triangle)equilateralTriangleFigure;
            var rectangularInvalidTriangle = (Triangle)rectangularInvalidTriangleFigure;

            Assert.IsFalse(invalidTriangle.isValid);
            Assert.IsTrue(rectangularTriangle.isValid);
            Assert.IsTrue(equilateralTriangle.isValid);
            Assert.IsFalse(rectangularInvalidTriangle.isValid);
        }

        [Test]
        public void IsTriangleRectangular()
        {
            var invalidTriangle = (Triangle)invalidTriangleFigure;
            var rectangularTriangle = (Triangle)rectangularTriangleFigure;
            var equilateralTriangle = (Triangle)equilateralTriangleFigure;
            var rectangularInvalidTriangle = (Triangle)rectangularInvalidTriangleFigure;

            Assert.IsFalse(invalidTriangle.IsRectangular);
            Assert.IsTrue(rectangularTriangle.IsRectangular);
            Assert.IsFalse(equilateralTriangle.IsRectangular);

            // Я исхожу из мнения, что невалидный треугольник не может иметь какой-либо тип,
            // потому что, фактически, это не существующий треугольник в условиях задания 
            Assert.IsFalse(rectangularInvalidTriangle.IsRectangular);
        }

        [Test]
        public void TriangleArea()
        {
            var invalidTriangleArea = invalidTriangleFigure.CalculateArea();
            var rectangularTriangleArea = rectangularTriangleFigure.CalculateArea();
            var equilateralTriangleArea = equilateralTriangleFigure.CalculateArea();
            var rectangularInvalidTriangleArea = rectangularInvalidTriangleFigure.CalculateArea();

            double tolerance = 0.1;
            Assert.AreEqual(invalidTriangleArea, 0);
            Assert.AreEqual(equilateralTriangleArea, 15.59, tolerance);
            Assert.AreEqual(rectangularTriangleArea, 6, tolerance);
            Assert.AreEqual(rectangularInvalidTriangleArea, 0);
        }
    }
}