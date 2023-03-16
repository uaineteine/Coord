namespace Uaine.Coord
{
    public class Ordinate<T> where T : struct
    {
        public T Value { get; set; }

        public Ordinate(T value)
        {
            Value = value;
        }

        public static Ordinate<T> operator +(Ordinate<T> a, Ordinate<T> b)
        {
            dynamic x = a.Value;
            dynamic y = b.Value;
            return new Ordinate<T>(x + y);
        }

        public static Ordinate<T> operator -(Ordinate<T> a, Ordinate<T> b)
        {
            dynamic x = a.Value;
            dynamic y = b.Value;
            return new Ordinate<T>(x - y);
        }

        public static Ordinate<T> operator *(Ordinate<T> a, Ordinate<T> b)
        {
            dynamic x = a.Value;
            dynamic y = b.Value;
            return new Ordinate<T>(x * y);
        }

        public static Ordinate<T> operator /(Ordinate<T> a, Ordinate<T> b)
        {
            float x = (float)a.Value;
            float y = b.Value;
            return new Ordinate<T>(x / y);
        }
    }
}
