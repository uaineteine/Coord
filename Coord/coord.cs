using System;

namespace Uaine.Coord
{
    public class coord
    {
        public coord(float xi, float yi)
        {
            x = xi;
            y = yi;
        }
        public coord(coord p)
        {
            x = p.x;
            y = p.y;
        }
        public coord(float xandy)
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
            if (x == 0 && y == 0) return 0;
            if (x > 0) return (y >= 0) ? 1 : 4;
            return (y >= 0) ? 2 : 3;
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

        public double DistanceFrom(coord a)
        {
            coord d = this - a;
            return d.Norm();
        }
        public static fcoord operator +(coord a, coord b)
            => new fcoord(a.x + b.x, a.y + b.y);

        public static coord operator +(coord a, coord b)
            => a + new coord(b);

        public static coord operator -(coord a)
            => new coord(-a.x, - a.y);

        public static coord operator -(coord a, coord b)
            => a + (-b);

        public static coord operator *(coord a, float b)
            => new coord(a.x * b, a.y * b);

        public static coord operator *(coord a, coord b)
            => new coord(a.x * b.x, a.y * b.y);

        public static coord operator /(coord a, float b)
            => new coord(a.x / b, a.y / b);

        public static coord operator /(coord a, coord b)
            => new coord(a.x / b.x, a.y / b.y);

        public static readonly coord zero = new coord(0, 0);
        public static readonly coord one = new coord(1, 1); //value of 1,1
    }
}
