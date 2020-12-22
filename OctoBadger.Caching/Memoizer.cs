using System;

namespace OctoBadger.Caching
{
    public class Memoizer
    {
        public static Func<T> Create<T>(Func<T> func)
        {
            return func;
        }
        public static Func<T, T2> Create<T, T2>(Func<T, T2> func)
        {
            return func;
        }
    }
}
