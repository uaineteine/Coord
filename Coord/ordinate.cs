namespace Uaine.Coord
{
    public class Ordinate<T>
    {
        private T value;

        public Ordinate(T value)
        {
            this.value = value;
        }
        public T Value
        {
            get { return value; }
            set { this.value = value; }
        }
    }

}
