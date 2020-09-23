using System;
using System.Collections.Generic;
using System.Text;

namespace Coord
{
    public class fcoord
    {
        public fcoord(float xi, float yi)
        {
            x = xi;
            y = yi;
        }
        public fcoord(coord p)
        {
            x = p.x;
            y = p.y;
        }
        public float x;
        public float y;

        public static fcoord operator +(fcoord a, fcoord b)
            => new fcoord(a.x + b.x, a.y + b.y);

        public static fcoord operator +(fcoord a, coord b)
            => a + new fcoord(b);

        public static fcoord operator -(fcoord a)
            => new fcoord(-a.x, - a.y);

        public static fcoord operator -(fcoord a, fcoord b)
            => a + (-b);

        public static fcoord operator *(fcoord a, float b)
            => new fcoord(a.x * b, a.y * b);

        public static fcoord operator *(fcoord a, fcoord b)
            => new fcoord(a.x * b.x, a.y * b.y);
    }
}
