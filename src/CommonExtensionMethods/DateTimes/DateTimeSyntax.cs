using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonExtensionMethods.DateTimes
{
    public class DateTimeSyntax
    {
        public int Offset { get; private set; }
        public Func<DateTime, int, DateTime> Calculation { get; private set; }

        public DateTimeSyntax(int offset, Func<DateTime, int, DateTime> calculation)
        {
            Offset = offset;
            Calculation = calculation;
        }

        public DateTime After(DateTime date)
        {
            return Calculation(date, Offset);
        }

        public DateTime Before(DateTime date)
        {
            return Calculation(date, -Offset);
        }
    }
}
