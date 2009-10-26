using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonExtensionMethods.Objects
{
    public abstract class Option<T>
    {
        public T Val { get; private set; }

        protected Option(T val) 
        {
            Val = val;
        }

        public virtual Option<T> IfSome(Action<T> action)
        {
            return this;
        }

        public Option<T> IfSome(Action action)
        {
            return IfSome(x => action());
        }

        public virtual Option<T> IfNone(Action<T> action)
        {
            return this;
        }

        public Option<T> IfNone(Action action)
        {
            return IfNone(x => action());
        }

        public static Option<T> Create(T val)
        {
            if (val == null)
            {
                return new None<T>(val);
            }

            return new Some<T>(val);
        }
    }

    public class None<T> : Option<T>
    {
        public None(T val) : base(val) {}

        public override Option<T> IfNone(Action<T> action)
        {
            action(Val);

            return this;
        }
    }

    public class Some<T> : Option<T>
    {
        public Some(T val) : base(val) { }

        public override Option<T> IfSome(Action<T> action)
        {
            action(Val);

            return this;
        }
    }
}
