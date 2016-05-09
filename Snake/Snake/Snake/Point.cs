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

        internal void Move(int offcet, Direction direction)
        {
            if (direction == Direction.RIGHT)
            {
                x += offcet; 
            }
            else if(direction == Direction.LEFT)
            {
                x -= offcet;
            }
            else if (direction == Direction.UP)
            {
                y -= offcet;
            }
            else if (direction == Direction.DOWN)
            {
                y += offcet;
            }
        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public void Clear()
        {
            sym = ' ';
            Draw();
        }
            
    }
}
