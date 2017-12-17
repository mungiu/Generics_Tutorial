using System;

namespace Generics_Tutorial
{
    internal class List
    {
        public void Add(int number)
        {
            throw new NotFiniteNumberException();
        }

        public int this[int index]
        {
            get { throw new NotFiniteNumberException(); }
        }

    }
}