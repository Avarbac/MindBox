using System;
using System.Collections.Generic;
using System.Text;

namespace SquareCalculator.Figures
{
    public class Circle : Figure
    {
        //Радиус круга
        private readonly double _radius;

        //Конструктор круга
        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentOutOfRangeException("Радиус не может быть ≤ 0");

            _radius = radius;
        }

        //Вычисляем площадь круна по радиусу
        internal override double SquareCalc()
        {
            return Math.PI * _radius * _radius;
        }
    }
}
