using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls
    {
        private List<Figure> lFigure;

        public Walls(int wWidth, int wHeight, char sym)
        {
            lFigure = new List<Figure>();

            HorizontalLine uphLine = new HorizontalLine(0, wWidth - 2, 0, sym);
            HorizontalLine dwnhLine = new HorizontalLine(0, wWidth - 2, wHeight - 1, sym);
            VerticalLine leftVLine = new VerticalLine(0, wHeight - 1, 0, sym);
            VerticalLine rightVLine = new VerticalLine(0, wHeight - 1, wWidth - 2, sym);

            lFigure.Add(uphLine);
            lFigure.Add(dwnhLine);
            lFigure.Add(leftVLine);
            lFigure.Add(rightVLine);

        }

        internal void Draw()
        {
            foreach (var fig in lFigure)
            {
                fig.Draw();
            }
        }

        internal bool IsHit(Figure figure)
        {
            foreach (var wall in lFigure)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
