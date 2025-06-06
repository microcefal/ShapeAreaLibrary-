using LibraryCricle.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCricle.Shapes
{
    public class Circle : IShape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
            Validate();
        }

        public void Validate()
        {
            if (Radius <= 0)
                throw new ArgumentException("Радиус должен быть положительным.");
        }

        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
