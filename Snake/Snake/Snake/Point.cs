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

        public char Sym { get { return sym; }  set { sym = value; } }

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

        public bool IsHit(Point head)
        {
            if (head.x == x && head.y == y) return true;           
            else return false;
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
