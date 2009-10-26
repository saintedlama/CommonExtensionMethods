using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonExtensionMethods.DateTimes
{
    public static class TimeExtensions
    {
        public static DateTimeSyntax Hours(this int offset)
        {
            return new DateTimeSyntax(offset, (x, y) => x.AddHours(y));
        }

        public static DateTimeSyntax Milliseconds(this int offset)
        {
            return new DateTimeSyntax(offset, (x, y) => x.AddMilliseconds(y));
        }

        public static DateTimeSyntax Minutes(this int offset)
        {
            return new DateTimeSyntax(offset, (x, y) => x.AddMinutes(y));
        }

        public static DateTimeSyntax Seconds(this int offset)
        {
            return new DateTimeSyntax(offset, (x, y) => x.AddSeconds(y));
        }
    }
}
