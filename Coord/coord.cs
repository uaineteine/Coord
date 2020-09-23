﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Coord
{
    public class coord
    {
        public coord(int xi, int yi)
        {
            x = xi;
            y = yi;
        }
        public int x;
        public int y;

        public int Mag()
        {
            return x * y;
        }

        public fcoord floatdiv(coord b)
        {
            return new fcoord((float)x / (float)b.x, (float)y / (float)b.y);
        }

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

        public static coord operator *(coord a, coord b)
            => new coord(a.x * b.x, a.y * b.y);
    }
}
