using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCricle.Abstractions
{
    public interface IShape : IValidatable
    {
        public double GetArea();
    }
}
