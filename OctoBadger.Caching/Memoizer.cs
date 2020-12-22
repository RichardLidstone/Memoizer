using System;

namespace OctoBadger.Caching
{
    public class Memoizer
    {
        public static Func<T> Create<T>(Func<T> func)
        {
            return func;
        }
    }
}
