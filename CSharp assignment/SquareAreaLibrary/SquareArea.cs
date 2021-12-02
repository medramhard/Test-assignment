using System;

namespace SquareAreaLib
{
    /// <summary>
    /// This particular class is meant to simply estimate square area for circle and triangle only.
    /// It might be easily extended if any other figure is needed
    /// </summary>
    public static class SquareArea
    {
        /// <summary>
        /// Calculates the square area of triangle using its sides.
        /// Returns -1 if input was incorrect or triangle does not exist.
        /// </summary>
        /// <param name="a">must be positive double number</param>
        /// <param name="b">must be positive double number</param>
        /// <param name="c">must be positive double number</param>
        /// /// <returns>Square area of triangle or -1 if input was incorrect</returns>
        public static double TriangleArea (double a, double b, double c)
        {
            //check if triangle exists
            if (a + b <= c || a + c <= b || b + c <= a)
                return -1;

            double semiperimeter = (a + b + c) / 2;

            double area = Math.Sqrt(semiperimeter * (semiperimeter - a) * (semiperimeter - b) * (semiperimeter - c));

            return area;
        }

        /// <summary>
        /// Calculates the square area of circle using its radius.
        /// </summary>
        /// <param name="radius">must be positive double number</param>
        /// <returns>Square area of circle or -1 if input was incorrect</returns>
        public static double CircleArea (double radius)
        {
            //check for wrong input
            if (radius <= 0)
                return -1;

            if (radius == double.MaxValue)
                throw new OverflowException($"System.Double can't contain more than {double.MaxValue}!");

            return radius * radius * Math.PI;
        }
    }

}
