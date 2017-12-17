namespace Generics_Tutorial
{
    /// <summary>
    /// Giving value types the ability to be nullable.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Nullable<T> where T : struct
    {
        private object _value;

        public Nullable()
        {
        }

        //ctor
        public Nullable(T value)
        {
            _value = value;
        }

        //checks if obj has value
        public bool HasValue
        {
            get { return _value != null; }
        }

        //returns value or default
        public T GetValueOrDefault()
        {
            if (HasValue)
                //cast object to T, safe since same type is passed in ctor
                return (T)_value;

            //returns the default of T whatever type it is
            return default(T);
        }
    }
}
