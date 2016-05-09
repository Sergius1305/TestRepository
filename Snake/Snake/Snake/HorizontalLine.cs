using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine : Figure
    {
        public HorizontalLine(int xLeft, int xRight, int y, char symb)
        {
            pList = new List<Point>();
            for (int x = xLeft; x <= xRight; x++)
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
