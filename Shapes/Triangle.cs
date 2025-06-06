using LibraryCricle.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCricle.Shapes
{
    public class Triangle : IShape
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
            Validate();
        }
        public void Validate()
        {
            if (A <= 0 || B <= 0 || C <= 0)
                throw new ArgumentException("Стороны треугольника должны быть положительными.");

            if (!(A + B > C && A + C > B && B + C > A))
                throw new ArgumentException("Нарушено неравенство треугольника.");
        }
        public double GetArea()
        {
            var sides = SortedSides;

            if (IsRightAngled())                         
                return 0.5 * sides[0] * sides[1];
            
            var s = (A + B + C) / 2;
            return Math.Sqrt(s * (s - A) * (s - B) * (s - C));
        }

        public bool IsRightAngled()
        {
            var sides = SortedSides;
            const double Epsilon = 1e-6;
            return Math.Abs(sides[2] * sides[2] - (sides[0] * sides[0] + sides[1] * sides[1])) < Epsilon;
        }

        private double[] SortedSides => new[] { A, B, C }.OrderBy(x => x).ToArray();
    }
}
