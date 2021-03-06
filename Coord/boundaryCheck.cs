﻿namespace Uaine.Coord
{
    public static class boundary
    {
        public static bool Check(coord p, coord size)
        {
            if (p.x >= 0 && p.y >= 0)
            {
                if (p.x < size.x && p.y < size.y)
                {
                    return true;
                }
            }
            //else
            return false;
        }
        public static bool Check(coord p, int w, int h)
        {
            return Check(p, new coord(w, h));
        }
        public static bool Check(int px, int py, coord size)
        {
            return Check(new coord(px, py), size);
        }
        public static bool Check(int x, int y, int w, int h)
        {
            return Check(new coord(x, y), new coord(w, h));
        }
    }
}
