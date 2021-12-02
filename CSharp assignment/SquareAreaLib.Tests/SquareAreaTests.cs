using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using SquareAreaLibrary;

namespace SquareAreaLib.Tests
{
    public class SquareAreaTests
    {
        [Theory]
        [InlineData(-10, 4, 6, -1)]
        [InlineData(0, 4, 6, -1)]
        [InlineData(3, -23, 5, -1)]
        [InlineData(11, 0, 15, -1)]
        [InlineData(20, 40, double.MinValue, -1)]
        [InlineData(8, 12, 0, -1)]
        [InlineData(double.MaxValue, 4, 8, -1)]
        [InlineData(45, double.MaxValue, 32.25, -1)]
        [InlineData(11.11, 19.08, double.MaxValue, -1)]
        public void TriangleArea_InvalidInputShouldFail(double a, double b, double c, double expected)
        {
            // Act
            double actual = SquareArea.TriangleArea(a, b, c);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3, 4, 5, 6)]
        [InlineData(3.25, 4, 5, 6.488)]
        [InlineData(34, 31, 5, 64.807)]
        [InlineData(17.34, 20, 28, 172.144)]
        [InlineData(11, 14, 16, 75.475)]
        [InlineData(0.823, 0.682, 0.479, 0.163)]
        [InlineData(0.5, 0.5, 0.5, 0.108)]
        [InlineData(100, 100, 30, 1483.029)]
        public void TriangleArea_ValidInputShouldCalculate(double a, double b, double c, double expected)
        {
            // Act
            double actual = SquareArea.TriangleArea(a, b, c);

            // Assert
            Assert.Equal(expected, actual, 3);
        }

        [Theory]
        [InlineData(-10, -1)]
        [InlineData(double.MinValue, -1)]
        [InlineData(0, -1)]
        public void CircleArea_InvalidInputShouldFail(double radius, double expected)
        {
            // Act
            double actual = SquareArea.CircleArea(radius);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3, 28.274)]
        [InlineData(100.25, 31573.203)]
        [InlineData(3.14, 30.975)]
        [InlineData(0.76, 1.815)]
        public void CircleArea_ValidInputShouldCalculate(double radius, double expected)
        {
            // Act
            double actual = SquareArea.CircleArea(radius);

            // Assert
            Assert.Equal(expected, actual, 3);
        }

        [Fact]
        public void CircleArea_MaxValueShouldFail()
        {
            // Assert
            Assert.Throws<OverflowException>(() => SquareArea.CircleArea(double.MaxValue));
        }
    }
}
