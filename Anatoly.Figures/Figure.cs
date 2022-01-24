using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anatoly.Figures
{
    internal abstract class Figure
    {
        private string _figureColour;
        private bool _isVisible;
        private int _positionX;
        private int _positionY;


        public int PositionX
        {
            get => _positionX;
            private set
            {
                _positionX = value;
            }
        }

        public int PositionY
        {
            get => _positionY;
            private set
            {
                _positionY = value;
            }
        }

        public Figure(string colour, bool state)
        {
            _figureColour = colour;
            _isVisible = state;
        }

        public void MoveFigureX(int deltaX) => PositionX += deltaX;
        public void MoveFigureY(int deltaY) => PositionY += deltaY;
        public void ChangeColor(string newColor) => _figureColour = newColor;
        public string CheckState() => _isVisible ? "Visible" : "Invisible";


        public virtual void ShowInfo()
        {
            Console.WriteLine($"Figure Colour: {_figureColour}\nState: {CheckState()}\nIs located in: ({_positionX};{_positionY})");
        }
    }



}

