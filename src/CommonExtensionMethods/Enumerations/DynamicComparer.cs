using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonExtensionMethods.Enumerations
{
    public class DynamicComparer<T, TResult> : IEqualityComparer<T>
    {
        private readonly Func<T, TResult> _selector;

        public DynamicComparer(Func<T, TResult> selector)
        {
            _selector = selector;
        }

        public bool Equals(T x, T y)
        {
            TResult result1 = _selector(x);
            TResult result2 = _selector(y);
            return result1.Equals(result2);
        }

        public int GetHashCode(T obj)
        {
            TResult result = _selector(obj);
            return result.GetHashCode();
        }
    }
}
