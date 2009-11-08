using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonExtensionMethods.Enumerations
{
    public static class EnumerationExtensions
    {
        public static bool Contains<T>(this IEnumerable<T> source, Func<T, bool> selector)
        {
            foreach (T item in source)
            {
                if (selector(item))
                {
                    return true;
                }
            }

            return false;
        }

        public static IEnumerable<T> Distinct<T, TResult>(this IEnumerable<T> source, Func<T, TResult> comparer)
        {
            return source.Distinct(new DynamicComparer<T, TResult>(comparer));
        }

        public static IEnumerable<T> Alternate<T>(this IEnumerable<T> first, IEnumerable<T> second)
        {
            using (IEnumerator<T> e1 = first.GetEnumerator())
            {
                using (IEnumerator<T> e2 = second.GetEnumerator())
                {
                    while (e1.MoveNext() && e2.MoveNext())
                    {
                        yield return e1.Current;
                        yield return e2.Current;
                    }
                }
            }
        }

        public static IEnumerable<T> Append<T>(this IEnumerable<T> source, T element)
        {
            foreach (var item in source)
            {
                yield return item;
            }

            yield return element;
        }

        public static IEnumerable<T> Prepend<T>(this IEnumerable<T> source, T element)
        {
            yield return element;

            foreach (var item in source)
            {
                yield return item;
            }
        }

        public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
        {
            ForEach(source, (i, item) => action(item));
        }

        public static void ForEach<T>(this IEnumerable<T> source, Action<int, T> action)
        {
            int i = 0;

            foreach (var item in source)
            {
                action(i++, item);
            }
        }

        public static IEnumerable<TTarget> ForEach<T, TTarget>(this IEnumerable<T> source, Func<T, TTarget> func)
        {
            return ForEach(source, (i, item) => func(item));
        }

        public static IEnumerable<TTarget> ForEach<T, TTarget>(this IEnumerable<T> source, Func<int, T, TTarget> func)
        {
            int i = 0;

            foreach (var item in source)
            {
                yield return func(i++, item);
            }
        }
    }
}
