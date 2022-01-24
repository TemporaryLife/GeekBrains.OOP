using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anatoly.Figures
{
    internal abstract class Point : Figure
    {
        public Point(string colour, bool state) : base(colour, state)
        {

        }

        public abstract double GetSquare();
    }
}
