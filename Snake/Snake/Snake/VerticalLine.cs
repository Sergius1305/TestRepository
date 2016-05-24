using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine : Figure
    {
        public VerticalLine(int yTop, int yBottom, int x, char symb)
        {
            pList = new List<Point>();
            for (int y = yTop; y <= yBottom; y++)
            {
                pList.Add(new Point(x, y, symb));
            }
        }

        public override void Draw()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            base.Draw();
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
