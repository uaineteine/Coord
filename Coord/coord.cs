using System;

namespace Uaine.Coord
{
    public class coord
    {
        public coord(int xi, int yi)
        {
            x = xi;
            y = yi;
        }
        public coord(coord b)
        {
            x = b.x;
            y = b.y;
        }
        public coord(int xandy)
        {
            x = xandy;
            y = xandy;
        }

        public int x;
        public int y;

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
            float v = x/y;
            return Math.Atan(v);
        }

        public int Mag()
        {
            return x * y;
        }

        public double Norm()
        {
            fcoord a = new fcoord(this);
            return a.Norm();
        }

        public fcoord toFloat()
        {
            return new fcoord(this);
        }

        public fcoord floatdiv(coord b)
        {
            return new fcoord((float)x / (float)b.x, (float)y / (float)b.y);
        }

        /*
        public void rationalise()
        {
            
        }
        */

        public static coord operator +(coord a, coord b)
            => new coord(a.x + b.x, a.y + b.y);

        public static coord operator +(coord a, int b)
            => new coord(a.x + b, a.y + b);

        public static coord operator -(coord a, int b)
            => new coord(a.x - b, a.y - b);

        public static coord operator -(coord a, coord b)
            => new coord(a.x - b.x, a.y - b.y);

        public static coord operator /(coord a, coord b)
            => new coord(a.x / b.x, a.y / b.y);

        public static coord operator /(coord a, int b)
            => new coord(a.x / b, a.y / b);

        public static coord operator *(coord a, coord b)
            => new coord(a.x * b.x, a.y * b.y);

        public static coord operator *(coord a, int b)
            => new coord(a.x * b, a.y * b);

        public readonly coord zero = new coord(0, 0);
        public readonly coord one = new coord(1, 1); //value of 1,1
    }
}
