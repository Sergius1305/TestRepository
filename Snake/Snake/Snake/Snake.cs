using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        private Direction direction;

        public Snake(Point tail, int length, Direction direction)
        {
            this.direction = direction;
            pList = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

        public void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();

        }

        private Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        internal bool IsHit()
        {
            var head = pList.Last();
            for (int i = 0; i < pList.Count - 2; i++)
            {
                if (head.IsHit(pList[i]))
                    return true;
            }
            return false;
        }

        internal void HandleKey(ConsoleKeyInfo key)
        {
            if (key.Key == ConsoleKey.LeftArrow)
            {
                direction = Direction.LEFT;
            }
            else if (key.Key == ConsoleKey.RightArrow)
            {
                direction = Direction.RIGHT;
            }
            else if (key.Key == ConsoleKey.UpArrow)
            {
                direction = Direction.UP;
            }
            else if (key.Key == ConsoleKey.DownArrow)
            {
                direction = Direction.DOWN;
            }
        }

        public bool Eat(Point foot)
        {
            Point head = GetNextPoint();
            if (head.IsHit(foot))
            {
                foot.Sym = head.Sym;
                pList.Add(foot);
                return true;
            }
            else
                return false;
        }
    }
}
