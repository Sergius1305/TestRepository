using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        private int x;
        private int y;
        private char sym;

        public Point() { }

        public Point(int x, int y, char symbol)
        {
            this.x = x;
            this.y = y;
            this.sym = symbol;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
            
    }
}
