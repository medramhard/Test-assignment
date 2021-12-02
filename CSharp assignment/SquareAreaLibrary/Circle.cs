using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareAreaLibrary
{
    public class Circle
    {
        public double Radius { get; private set; }
        private bool _isValid;

        /// <param name="radius">Must be positive number</param>
        public Circle(double radius)
        {
            Radius = radius;
            IsValid(radius);
        }

        private void IsValid(double radius)
        {
            if (radius <= 0)
                _isValid = false;
            else
                _isValid = true;
        }

        /// <summary>
        /// Calculates square area of circle using its radius
        /// </summary>
        /// <returns>Square area of circle or -1 if circle does not exist</returns>
        public double Area()
        {
            if (!_isValid)
                return -1;

            if (Radius == double.MaxValue)
                throw new OverflowException($"System.Double can't contain more than {double.MaxValue}!");

            double area = Math.Round(Math.PI * Math.Pow(Radius, 2), 3);
           
            return area;                   
        }
    }
}
