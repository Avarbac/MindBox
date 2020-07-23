using System;

namespace SquareCalculator.Figures
{
    public abstract class Figure
    {
        internal abstract double SquareCalc();
    
    //На случай, если не известен тип фигуры. Подходит только в нынешних условиях. С добавлением новых фигур могут возникнуть нестыковки.
    //public double SquareCalc(double radius)
    //{
    //    return Math.PI * radius * radius;
    //}

    //public double SquareCalc(double firstSide, double secondSide, double thirdSide)
    //{
    //    var semiPerimeter = (firstSide + secondSide + thirdSide) / 2;

    //    var firstSideCoefficient = semiPerimeter - firstSide;
    //    var secondSideCoefficient = semiPerimeter - secondSide;
    //    var thirdSideCoefficient = semiPerimeter - thirdSide;

    //    return Math.Sqrt(semiPerimeter * firstSideCoefficient * secondSideCoefficient * thirdSideCoefficient);
    //}
    }
}
