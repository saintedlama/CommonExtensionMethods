using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonExtensionMethods.Enumerations
{
    public static class GeneratorExtensions
    {
        public static IEnumerable<int> Times(this int times)
        {
            return Times(times, i => i);
        }

        public static IEnumerable<long> Times(this long times)
        {
            return Times(times, i => i);
        }

        public static IEnumerable<T> Times<T>(this int times, Func<int, T> func)
        {
            for (int i = 0; i < times; i++)
            {
                yield return func(i);
            }
        }

        public static IEnumerable<T> Times<T>(this long times, Func<long, T> func)
        {
            for (long i = 0; i < times; i++)
            {
                yield return func(i);
            }
        }
    }
}
