using System;

namespace Anatoly.Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Rectangle circ = new Rectangle("blue", true, 5,2);

            circ.ShowInfo();
            Console.WriteLine($"{circ.GetSquare()}");
            circ.MoveFigureX(5);
            circ.MoveFigureX(5);
            circ.MoveFigureY(5);
            circ.MoveFigureY(-3);

            circ.ShowInfo();

        }
    }
}
