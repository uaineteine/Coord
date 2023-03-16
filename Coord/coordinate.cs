namespace Uaine.Coord
{
    public class Coordinate<T>
    {
        private readonly Ordinate<T>[] coordinates;

        public Coordinate(params Ordinate<T>[] coordinates)
        {
            this.coordinates = coordinates;
        }

        public int Length
        {
            get { return coordinates.Length; }
        }

        public Ordinate<T> this[int index]
        {
            get { return coordinates[index]; }
            set { coordinates[index] = value; }
        }
    }

}
