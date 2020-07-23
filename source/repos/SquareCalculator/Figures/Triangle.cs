using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SquareCalculator.Figures
{
    public class Triangle : Figure
    {
        //Стороны треугольника
        private readonly double _firstSide;
        private readonly double _secondSide;
        private readonly double _thirdSide;

        //Конструктор треугольника
        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
                throw new ArgumentOutOfRangeException("Сторона не может быть ≤ 0");

            _firstSide = firstSide;
            _secondSide = secondSide;
            _thirdSide = thirdSide;
        }

        //Провереям является ли треугольник прямоугольным
        private bool CheckIsRightAngled()
        {
            var maxSide = new[] { _firstSide, _secondSide, _thirdSide }.Max();
            var maxSideSqr = maxSide * maxSide;
            return maxSideSqr + maxSideSqr == _firstSide * _firstSide + _secondSide * _secondSide + _thirdSide * _thirdSide;
        }

        //Вычисляем площадь треугольника по 3м сторонам
        internal override double SquareCalc()
        {
            var semiPerimeter = (_firstSide + _secondSide + _thirdSide) / 2;

            var firstSideCoefficient = semiPerimeter - _firstSide;
            var secondSideCoefficient = semiPerimeter - _secondSide;
            var thirdSideCoefficient = semiPerimeter - _thirdSide;

            return Math.Sqrt(semiPerimeter * firstSideCoefficient * secondSideCoefficient * thirdSideCoefficient);
        }

    }
}
