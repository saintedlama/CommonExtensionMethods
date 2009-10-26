using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonExtensionMethods.DateTimes
{
    public static class DateExtensions
    {
        public static DateTimeSyntax Days(this int offset)
        {
            return new DateTimeSyntax(offset, (x, y) => x.AddDays(y));
        }

        public static DateTimeSyntax Month(this int offset)
        {
            return new DateTimeSyntax(offset, (x, y) => x.AddMonths(y));
        }

        public static DateTimeSyntax Years(this int offset)
        {
            return new DateTimeSyntax(offset, (x, y) => x.AddYears(y));
        }
    }
}
