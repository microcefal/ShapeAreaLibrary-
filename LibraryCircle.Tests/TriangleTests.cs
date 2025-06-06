using LibraryCricle.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LibraryCricle.LibraryCircle.Tests
{
    public class TriangleTests
    {
        [Fact]
        public void Triangle_ValidSides_ShouldCalculateArea()
        {
            var triangle = new Triangle(3, 4, 5);
            var area = triangle.GetArea();
            Assert.Equal(6, area, 5); 
        }

        [Fact]
        public void Triangle_InvalidSides_ShouldThrow()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(1, 1, 3));
        }

        [Fact]
        public void Triangle_ShouldDetectRightAngled()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.True(triangle.IsRightAngled());
        }

        [Fact]
        public void Triangle_NotRightAngled_ShouldReturnFalse()
        {
            var triangle = new Triangle(4, 5, 6);
            Assert.False(triangle.IsRightAngled());
        }
    }
}
