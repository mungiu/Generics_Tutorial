using System;

namespace Generics_Tutorial
{

    // where T : IComparable
    // where T : Product (or any of it's children/subclasses)
    // where T : struct (value type)
    // where T : class (reference type)
    // where T : new() (object with default contructor)
    public class Utilities<T> where T : IComparable, new()
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        public void DoSomething(T value)
        {
            var obj = new T();
        }

        //we make sure both a & b implement IComparable interface
        //which provides a metho called CompareTo();
        public T Max(T a, T b)
        {
            ////this will not work 
            ////it assumes a & b are objects and cant compare them
            //return a > b ? a : b;

            //this method returns 1 if a is different than b
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}
