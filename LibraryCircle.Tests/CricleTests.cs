using LibraryCricle.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LibraryCricle.LibraryCircle.Tests
{
    public class CircleTests
    {
        [Fact]
        public void Circle_WithPositiveRadius_ShouldCalculateArea()
        {
            var circle = new Circle(2);
            var area = circle.GetArea();
            Assert.Equal(Math.PI * 4, area, 5);
        }

        [Fact]
        public void Circle_WithNegativeRadius_ShouldThrow()
        {
            Assert.Throws<ArgumentException>(() => new Circle(-1));
        }
    }
}
