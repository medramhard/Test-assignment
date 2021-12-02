using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareAreaLibrary
{
    public class Triangle
    {
        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }
        private bool _isValid;

        /// <summary>
        /// The sum of two side lengths of a triangle must always be greater than the third side
        /// </summary>
        /// <param name="a">Must be positive number</param>
        /// <param name="b">Must be positive number</param>
        /// <param name="c">Must be positive number</param>
        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
            IsValid(a, b, c);
        }

        private void IsValid(double a, double b, double c)
        {
            if (a + b <= c || a + c <= b || b + c <= a)
                _isValid = false;
            else
                _isValid = true;
        }

        /// <summary>
        /// Calculates square area of triangle using its sides
        /// </summary>
        /// <returns>Square area of triangle or -1 if triangle does not exist</returns>
        public double Area()
        {
            if (!_isValid)
                return -1;

            double semiperimeter = (A + B + C) / 2;
            double area = Math.Round(Math.Sqrt(semiperimeter * (semiperimeter - A) * (semiperimeter - B) * (semiperimeter - C)), 3);

            return area;            
        }

        /// <summary>
        /// Checks if triangle is right-angled
        /// </summary>
        /// <param name="triangle"></param>
        /// <returns>True if triangle is right-angled and False otherwise</returns>
        public bool IsRightAngled()
        {
            if (_isValid && (
                Math.Pow(A, 2) == Math.Pow(B, 2) + Math.Pow(C, 2) ||
                Math.Pow(B, 2) == Math.Pow(A, 2) + Math.Pow(C, 2) ||
                Math.Pow(C, 2) == Math.Pow(A, 2) + Math.Pow(B, 2)))
                return true;
            else
                return false;
        }

    }
}
