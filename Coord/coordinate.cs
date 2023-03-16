namespace Uaine.Coord
{
    public class Coordinate<T>
    {
        private Ordinate<T> x;
        private Ordinate<T> y;
        private Ordinate<T> z;

        public Coordinate(Ordinate<T> x, Ordinate<T> y, Ordinate<T> z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public Ordinate<T> X
        {
            get { return x; }
            set { x = value; }
        }

        public Ordinate<T> Y
        {
            get { return y; }
            set { y = value; }
        }

        public Ordinate<T> Z
        {
            get { return z; }
            set { z = value; }
        }
    }
}
