using System;

namespace Generics_Tutorial
{
    class BookList
    {
        public void Add(Book book)
        {
            throw new NotFiniteNumberException();
        }

        public Book this[int index]
        {
            get { throw new NotFiniteNumberException(); }
        }

    }

    public class GenericDictionary<TKey, TValue>
    {
        public void Add(TKey key, TValue value)
        {

        }
    }

    //Generic list with parameter of type <T>
    public class GenericList<T>
    {
        public void Add(T value)
        {

        }

        //getting the object at the given index (returning T)
        public T this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }

}
