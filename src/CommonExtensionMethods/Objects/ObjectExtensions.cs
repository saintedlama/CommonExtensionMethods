using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonExtensionMethods.Objects
{
    public static class ObjectExtensions
    {
        public static T IfNull<T>(this T obj, Action action)
        {
            if (obj == null)
            {
                action();
            }

            return obj;
        }

        public static T IfNull<T>(this T obj, Func<T> func)
        {
            if (obj == null)
            {
                return func();
            }

            return obj;
        }

        public static T IfNotNull<T>(this T obj, Action<T> action)
        {
            if (obj != null) 
            {
                action(obj);
            }
            
            return obj;
        }

        public static T IfNotNull<T>(this T obj, Action action)
        {
            if (obj != null)
            {
                action();
            }

            return obj;
        }

        public static Option<T> AsOption<T>(this T obj)
        {
            return Option<T>.Create(obj);
        }
    }
}
