using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anatoly.Figures
{
    internal sealed class Circle : Point
    {
        private int _radius;
        private const double pi = 3.1415d;
        public Circle(string colour, bool state, int radius) : base(colour, state)
        {
            _radius = radius;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Radius: {_radius}");
        }

        public override double GetSquare() => pi * _radius * _radius;

    }
}
