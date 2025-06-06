using LibraryCricle.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCricle.Shapes
{
    public class Rectangle : IShape
    {
        public double Width { get; }
        public double Height { get; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
            Validate();
        }

        public void Validate()
        {
            if (Width <= 0 || Height <= 0)
                throw new ArgumentException("Стороны прямоугольника должны быть положительными.");
        }

        public double GetArea() => Width * Height;
    }
}
