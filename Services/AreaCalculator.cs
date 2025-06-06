using LibraryCricle.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCricle.Services
{
    public class AreaCalculator
    {
        
        public double CalculateArea(IShape shape)
        {
            shape.Validate();
            return shape.GetArea();
        }
    }
}
