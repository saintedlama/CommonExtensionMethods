using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonExtensionMethods.Booleans
{
    public static class BooleanExtensions
    {
        public static bool IfTrue(this bool decision, Action action)
        {
            if (decision)
            {
                action();
            }

            return decision;
        }

        public static bool IfFalse(this bool decision, Action action)
        {
            return IfTrue(!decision, action);
        }
    }
}
