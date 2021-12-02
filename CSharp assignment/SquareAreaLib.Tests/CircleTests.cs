using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using SquareAreaLibrary;

namespace SquareAreaLib.Tests
{
    public class CircleTests
    {
        [Theory]
        [InlineData(-10, -1)]
        [InlineData(double.MinValue, -1)]
        [InlineData(0, -1)]
        public void Area_InvalidInputShouldFail(double radius, double expected)
        {
            // Arrange
            Circle circle = new Circle(radius);

            // Act
            double actual = circle.Area();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3, 28.274)]
        [InlineData(100.25, 31573.203)]
        [InlineData(3.14, 30.975)]
        [InlineData(0.76, 1.815)]
        public void Area_ValidInputShouldCalculate(double radius, double expected)
        {
            // Arrange
            Circle circle = new Circle(radius);

            // Act
            double actual = circle.Area();

            // Assert
            Assert.Equal(expected, actual, 3);
        }

        [Fact]
        public void Area_MaxValueShouldFail()
        {
            // Arrange
            Circle circle = new Circle(double.MaxValue);

            // Assert
            Assert.Throws<OverflowException>(() => circle.Area());
        }
    }
}
