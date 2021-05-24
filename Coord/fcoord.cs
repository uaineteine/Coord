using System;

namespace Uaine.Coord
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
        public fcoord(float xandy)
        {
            x = xandy;
            y = xandy;
        }
        public float x;
        public float y;

        //0 is origin, 1 to 4 are coord quadrants, expecting something not on an axis
        
        
        public int quadrant()
        {
            //return quad coord is in
            if (x == 0 & y == 0)
                return 0;
            else if (x > 0)
            {
                if (y >= 0)
                    return 1;
                else
                    return 4;
            }
            else
            {
                if (y >= 0)
                    return 2;
                else
                    return 3;
            }
        }

        public double angle()
        {
            float v = x / y;
            return Math.Atan(v);
        }

        public float Mag()
        {
            return x * y;
        }

        public double Norm()
        {
            double xd = (double)x;
            double yd = (double)y;
            return Math.Sqrt(xd*xd + yd*yd);
        }

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

        public static fcoord operator /(fcoord a, float b)
            => new fcoord(a.x / b, a.y / b);

        public static fcoord operator /(fcoord a, fcoord b)
            => new fcoord(a.x / b.x, a.y / b.y);

        public static readonly fcoord zero = new fcoord(0, 0);
        public static readonly fcoord one = new fcoord(1, 1); //value of 1,1
    }
}
