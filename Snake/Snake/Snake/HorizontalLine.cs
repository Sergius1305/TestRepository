﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine
    {
        private List<Point> pList;

        public HorizontalLine(int xLeft, int xRight, int y, char symb)
        {
            pList = new List<Point>();
            for (int x = xLeft; x <= xRight; x++)
            {
                pList.Add(new Point(x, y, symb));
            }
        }

        public void Draw()
        {
            foreach (var p in pList)
            {
                p.Draw();
            }
        }
    }
}
