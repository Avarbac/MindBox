using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SquareCalculator.Figures;

namespace SquareCalculatorTest
{
    [TestClass]
    public class SquarerCalculatorTests
    {
        // Тестируем отрицательный радиус круга
        [TestMethod]
        public void CircleNegativeRadiusTest()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Circle(-5));
        }

        // Тестируем стороны треугольника
        [TestMethod]
        public void TriangleNegativeSidesTest()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(-5, 0, 0));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(0, -5, 0));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(0, 0, -5));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(-5, -5, -5));
        }

        // Тестируем вычисление площади круга
        [TestMethod]
        public void CircleSqrCalculationTest()
        {
            //Arrange
            var circle = new Circle(10);
            double expected = Math.PI * 10 * 10;

            //Act
            double actual = circle.SquareCalc();
            
            //Assert
            Assert.AreEqual(expected, actual);
        }

        // Тестируем вычисление площади треугольника
        [TestMethod]
        public void TriangleSqrCalculationTest()
        {
            //Arrange
            var triangle = new Triangle(5,4,3);
            double expected = 6;

            //Act
            double actual = triangle.SquareCalc();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        // Тестируем прямоугольный треугольник
        [TestMethod]
        public void RightAngleTriangleTest()
        {
            //Arrange
            var triangle = new Triangle(5,4,3);

            //Act
            var actual = triangle.CheckIsRightAngled();

            //Assert
            Assert.IsTrue(actual);
        }

        // Тестируем непрямоугольный треугольник
        [TestMethod]
        public void NotRightAngleTriangleTest()
        {
            //Arrange
            var triangle = new Triangle(8,6,3);

            //Act
            var actual = triangle.CheckIsRightAngled();

            //Assert
            Assert.IsFalse(actual);
        }
    }
}
