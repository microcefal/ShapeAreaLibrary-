using LibraryCricle.Services;
using LibraryCricle.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LibraryCricle.LibraryCircle.Tests
{
    public class AreaCalculatorTests
    {
        private readonly AreaCalculator _calculator = new();

        [Fact]
        public void Calculator_ShouldWorkWithCircle()
        {
            var circle = new Circle(2);
            var result = _calculator.CalculateArea(circle);
            Assert.Equal(Math.PI * 4, result, 5);
        }

        [Fact]
        public void Calculator_ShouldWorkWithTriangle()
        {
            var triangle = new Triangle(3, 4, 5);
            var result = _calculator.CalculateArea(triangle);
            Assert.Equal(6, result, 5);
        }
    }
}
