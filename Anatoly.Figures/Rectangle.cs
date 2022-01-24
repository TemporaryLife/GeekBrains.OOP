using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anatoly.Figures
{
    internal sealed class Rectangle : Point
    {
        private double _width;
        private double _height;
        public Rectangle(string colour, bool state, double width, double height) : base(colour, state)
        {
            _height = height;
            _width = width;

        }

        public override double GetSquare() => _width * _height;

    }
}
