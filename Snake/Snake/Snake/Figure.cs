using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figure
    {
        protected List<Point> pList;

        public virtual void Draw()
        {
            foreach (var p in pList)
            {
                p.Draw();
            }
        }

        public bool IsHit(Figure figure)
        {
            foreach (var p in pList)
            {
                if (figure.IsHit(p))
                {
                    return true;
                }
            }

            return false;
        }

        public bool IsHit(Point point)
        {
            foreach (var p in pList)
            {
                if (p.IsHit(point))
                {
                    return true;
                }
            }
            return false;
        }


    }
}
